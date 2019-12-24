/*
*┌────────────────────────────────────────────────┐
*│　描    述：Banner                                                    
*│　作    者：mask                                              
*│　版    本：1.0                                              
*│　创建时间：2019/12/23 10:27:36                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublish.Model.Entity
{
    public class Banner
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public DateTime AddTime { get; set; }
        public string Remark { get; set; }
    }
}
