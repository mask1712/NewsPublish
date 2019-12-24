/*
*┌────────────────────────────────────────────────┐
*│　描    述：NewsComment                                                    
*│　作    者：mask                                              
*│　版    本：1.0                                              
*│　创建时间：2019/12/23 10:27:03                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublish.Model.Entity
{
    public class NewsComment
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public string Contents { get; set; }
        public DateTime AddTime { get; set; }
        public string Remark { get; set; }
        public virtual News News { get; set; }
    }
}
