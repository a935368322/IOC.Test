
/*
 * 本文件由根据实体插件自动生成，请勿更改
 * =========================== */

using System;
using Kogel.Dapper.Extension.Attributes;
namespace IOC.Model
{
    public class project_Role
    {
        /// <summary>
        /// 角色id
        /// </summary>    
       [Identity]
        public int id{ get; set; }
        
        /// <summary>
        /// 角色名称
        /// </summary>    
        public string name{ get; set; }
        
        /// <summary>
        /// 角色父级id,0为最高等级角色
        /// </summary>    
        public int parentId{ get; set; }
        
        /// <summary>
        /// 角色描述
        /// </summary>    
        public string description{ get; set; }
        
        /// <summary>
        /// 是否启用
        /// </summary>    
        public bool enabled{ get; set; }
        
        /// <summary>
        /// 创建时间
        /// </summary>    
        public DateTime createDate{ get; set; }
        
        /// <summary>
        /// 创建人
        /// </summary>    
        public string createUsers{ get; set; }
        
        /// <summary>
        /// 项目id
        /// </summary>    
        public int projectId{ get; set; }
    }
}
