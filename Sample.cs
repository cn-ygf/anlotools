using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnloTools
{
    /// <summary>
    /// 检材实体类
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 检材编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 检材类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 封存状态
        /// </summary>
        public string Seal { get; set; }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string Info { get; set; }
    }
}
