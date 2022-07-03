﻿using GreenOnions.Interface;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace GreenOnions.ReplierWindow
{
    public class Replier : IPlugin
    {
        public Func<long, GreenOnionsMessages, Task<int>> SendFriendMessage;
        public Func<long, GreenOnionsMessages, Task<int>> SendGroupMessage;
        private string _pluginPath;
        private string _configFileName;
        private string _imagePath;
        private List<CommandSetting> _commandTable = new List<CommandSetting>();

        public string Name => "自定义回复";

        public string Description => "自定义回复";

        public void ConsoleSetting()
        {

        }

        public void OnConnected(long selfId, Func<long, GreenOnionsMessages, Task<int>> sendFriendMessage, Func<long, GreenOnionsMessages, Task<int>> sendGroupMessage, Func<long, long, GreenOnionsMessages, Task<int>> sendTempMessage)
        {
            SendFriendMessage = sendFriendMessage;
            SendGroupMessage = sendGroupMessage;
        }

        public void OnDisconnected()
        {

        }

        public void OnLoad(string pluginPath)
        {
            _pluginPath = pluginPath;
            _imagePath = Path.Combine(_pluginPath, "Images");
            _configFileName = Path.Combine(_pluginPath, "config.json");
            if (File.Exists(_configFileName))
                _commandTable = JsonConvert.DeserializeObject<List<CommandSetting>>(File.ReadAllText(_configFileName))!;
        }

        public bool OnMessage(GreenOnionsMessages msgs, long? senderGroup, Action<GreenOnionsMessages> Response)
        {
            if (msgs.First() is GreenOnionsTextMessage textMsg)
            {
                var comms = _commandTable.OrderBy(c => c.Priority);
                foreach (var comm in comms)
                {
                    if (comm.TriggerMode == TriggerModes.群组消息 && senderGroup != null)
                    {
                        GreenOnionsMessages reply = CaeateReply(textMsg, comm);
                        if (reply != null)
                        {
                            reply.Reply = comm.ReplyMode;
                            Response(reply);
                            return true;
                        }
                    }
                    else
                    {
                        GreenOnionsMessages reply = CaeateReply(textMsg, comm);
                        if (reply != null)
                        {
                            Response(reply);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private GreenOnionsMessages CaeateReply(GreenOnionsTextMessage textMsg, CommandSetting comm)
        {
            if (comm.MatchMode == MatchModes.完全 && textMsg.Text == comm.Message)
                return ReplaceImages(comm.ReplyValue);
            else if (comm.MatchMode == MatchModes.前缀 && textMsg.Text.StartsWith(comm.Message))
                return ReplaceImages(comm.ReplyValue);
            else if (comm.MatchMode == MatchModes.后缀 && textMsg.Text.EndsWith(comm.Message))
                return ReplaceImages(comm.ReplyValue);
            else if (comm.MatchMode == MatchModes.正则表达式)
            {
                Regex regex = new Regex(comm.Message);
                Match match = regex.Match(textMsg.Text);
                if (match.Value == textMsg.Text)
                    return ReplaceImages(comm.ReplyValue);
            }
            else if (comm.MatchMode == MatchModes.包含 && textMsg.Text.Contains(comm.Message))
                return ReplaceImages(comm.ReplyValue);
            return null;
        }

        private GreenOnionsMessages ReplaceImages(string textMessage)
        {
            Dictionary<string, string> imageNameAndPaths = new Dictionary<string, string>();
            List<string> splitedText = new List<string>();
            splitedText.Add(textMessage);

            string[] imgs = Directory.GetFiles(_imagePath);
            for (int i = 0; i < imgs.Length; i++)
            {
                string imgTag = $"<{Path.GetFileName(imgs[i])}>";
                imageNameAndPaths.Add(imgTag, imgs[i]);
            IL_Research:;
                for (int j = 0; j < splitedText.Count; j++)
                {
                    if (splitedText[j] != imgTag && splitedText[j].Contains(imgTag))
                    {
                        string originalMsg = splitedText[j];
                        splitedText.RemoveAt(j);
                        string[] splited = originalMsg.Split(imgTag);
                        for (int k = 0; k < splited.Length; k++)
                        {
                            splitedText.Add(splited[k]);
                            if (k < splited.Length -1)
                                splitedText.Add(imgTag);
                        }
                        goto IL_Research;
                    }
                }
            }
            GreenOnionsMessages messages = new GreenOnionsMessages();
            for (int i = 0; i < splitedText.Count; i++)
            {
                if (imageNameAndPaths.ContainsKey(splitedText[i]))
                    messages.Add(new GreenOnionsImageMessage(imageNameAndPaths[splitedText[i]]));
                else
                    messages.Add(new GreenOnionsTextMessage(splitedText[i]));
            }
            return messages;
        }

        public bool WindowSetting()
        {
            new FrmSetting(_commandTable, _pluginPath).ShowDialog();
            string jsonValue = JsonConvert.SerializeObject(_commandTable);
            File.WriteAllText(Path.Combine(_pluginPath, "config.json"), jsonValue);
            return true;
        }
    }

    public struct CommandSetting
    {
        /// <summary>
        /// 触发消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 匹配模式
        /// </summary>
        public MatchModes MatchMode { get; set; }
        /// <summary>
        /// 触发模式
        /// </summary>
        public TriggerModes TriggerMode { get; set; }
        /// <summary>
        /// 回复内容
        /// </summary>
        public string ReplyValue { get; set; }
        /// <summary>
        /// 以"回复"方式发送(仅限群)
        /// </summary>
        public bool ReplyMode { get; set; }
        /// <summary>
        /// 优先级
        /// </summary>
        public int Priority { get; set; }

    }

    public enum MatchModes
    {
        完全 = 0,
        包含 = 1,
        前缀 = 2,
        后缀 = 3,
        正则表达式 = 4,
    }

    public enum TriggerModes
    {
        好友消息 = 1,
        群组消息 = 2,
    }
}