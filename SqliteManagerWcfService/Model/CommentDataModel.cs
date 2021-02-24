using System.Runtime.Serialization;

namespace SqliteManagerWcfService.Model
{
    /// <summary>
    /// 评论页采集评论用模型
    /// </summary>
    [DataContract]
    public class CommentDataModel
    {
        /// <summary>
        /// 序号
        /// </summary>
        [DataMember]
        public string Number { get; set; }

        /// <summary>
        /// 短ID
        /// </summary>
        [DataMember]
        public string ShortId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [DataMember]
        public string NickName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [DataMember]
        public string Phone { get; set; }

        /// <summary>
        /// 用户主页Url
        /// </summary>
        [DataMember]
        public string ShareUrl { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        public string Gender { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [DataMember]
        public string Signature { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [DataMember]
        public string CommentText { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        [DataMember]
        public string CreateTime { get; set; }

        /// <summary>
        /// 本条点赞数
        /// </summary>
        [DataMember]
        public string DiggCount { get; set; }

        /// <summary>
        /// 采集时间
        /// </summary>
        [DataMember]
        public string UpTime { get; set; }
    }
}
