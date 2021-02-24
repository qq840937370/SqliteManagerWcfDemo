using System.Runtime.Serialization;

namespace SqliteManagerWcfService.Model
{
    /// <summary>
    /// 采集直播间弹幕用模型
    /// </summary>
    [DataContract]
    public class LiveDataModel
    {
        /// <summary>
        /// msgid
        /// </summary>
        [DataMember]
        public string MsgId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [DataMember]
        public string UserId { get; set; }

        /// <summary>
        /// 用户短ID
        /// </summary>
        [DataMember]
        public string ShortId { get; set; }

        /// <summary>
        /// 用户显示用ID
        /// </summary>
        [DataMember]
        public string DisplayId { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [DataMember]
        public string NickName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        public string Gender { get; set; }

        /// <summary>
        /// 唯一标识SecUid
        /// </summary>
        [DataMember]
        public string SecUid { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [DataMember]
        public string UpTime { get; set; }

        /// <summary>
        /// 用户主页Url
        /// </summary>
        [DataMember]
        public string ShareUrl { get; set; }

        /// <summary>
        /// 弹幕内容
        /// </summary>
        [DataMember]
        public string Content { get; set; }
    }
}
