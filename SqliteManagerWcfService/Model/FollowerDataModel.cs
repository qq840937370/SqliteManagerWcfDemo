
using System.Runtime.Serialization;

namespace SqliteManagerWcfService.Model
{
    /// <summary>
    /// 粉丝页采集粉丝用模型
    /// </summary>
    [DataContract]
    public class FollowerDataModel
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [DataMember]
        public string UId { get; set; }

        /// <summary>
        /// 用户短ID
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
        /// 短手机号
        /// </summary>
        [DataMember]
        public string ShortPhone { get; set; }

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
        /// 用户主页
        /// </summary>
        [DataMember]
        public string ShareUrl { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [DataMember]
        public string UpTime { get; set; }
    }
}
