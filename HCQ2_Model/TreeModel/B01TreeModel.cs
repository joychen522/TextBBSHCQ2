using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCQ2_Model.TreeModel
{
    /// <summary>
    ///  单位业务树模型
    /// </summary>
    public class B01TreeModel
    {
        /// <summary>
        ///  树节点ID
        /// </summary>
        public int nodeId { get; set; }
        /// <summary>
        ///  节点名称
        /// </summary>
        public string text { get; set; }
        /// <summary>
        ///  单位代码
        /// </summary>
        public string unitID { get; set; }
        /// <summary>
        ///  子节点数量
        /// </summary>
        public int keyChild { get; set; }
        /// <summary>
        ///  拼音首字母
        /// </summary>
        public string JPSign { get; set; }
        /// <summary>
        ///  子节点，可以用递归的方法读取
        /// </summary>
        public List<B01TreeModel> nodes { get; set; }
    }
}
