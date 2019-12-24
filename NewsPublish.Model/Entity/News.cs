/*
*┌────────────────────────────────────────────────┐
*│　描    述：News                                                    
*│　作    者：mask                                              
*│　版    本：1.0                                              
*│　创建时间：2019/12/23 10:26:13                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublish.Model.Entity
{
    public class News
    {
        public News()
        {
            this.NewsComment = new HashSet<NewsComment>();
        }

        public int Id { get; set; }
        public int NewsClassifyId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Contents { get; set; }
        public DateTime PublishDate { get; set; }
        public string Remark { get; set; }
        public virtual NewsClassify NewsClassify { get; set; }
        public virtual ICollection<NewsComment> NewsComment { get; set; }
    }
}
