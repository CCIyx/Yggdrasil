﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yggdrasil.Model
{
    class Comment
    {
        private int comment_id;
        private int book_id;
        private int user_id;
        private string content;
        private string user_name;
        private DateTime create_date;
        public DateTime Create_date { get { return create_date; } set { create_date = value; } }

        public int Comment_id { get { return comment_id; } set { comment_id = value; } }
        public int Book_id { get { return book_id; } set { book_id = value; } }
        public int User_id { get { return user_id; } set { user_id = value; } }
        public string Content { get { return content; } set { content = value; } }
        public string User_name { get { return user_name; } set { user_name = value; } }

    }
}
