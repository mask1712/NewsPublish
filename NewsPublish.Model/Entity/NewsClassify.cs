/*
*┌────────────────────────────────────────────────┐
*│　描    述：NewsClassify                                                    
*│　作    者：mask                                              
*│　版    本：1.0                                              
*│　创建时间：2019/12/23 10:28:10                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublish.Model.Entity
{
    public class NewsClassify
    {
        public NewsClassify()
        {
            this.News = new HashSet<News>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
