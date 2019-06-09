using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlThucDon
{   //Product
    class MonAn : Observer
    {
        
        private List<ChatDinhDuong> chatDinhDuongs = new List<ChatDinhDuong>();

        public MonAn()
        {
            
        }

        public void MonAnRefresh()
        {
            chatDinhDuongs.Clear();
            chatDinhDuongs = new List<ChatDinhDuong>();
        }

        public void MonAnThem(float[] arr)
        {
            //lưu ý thứ tự truyền vào array phải khớp với lúc monAn.Add()
            int i = 0;
            foreach (ChatDinhDuong chat in chatDinhDuongs)
            {
                chat.Value = arr[i++];
            }
        }

        public override void update()
        {
            foreach(ChatDinhDuong chatDinhDuong in chatDinhDuongs)
            {
                if (chatDinhDuong != null)
                {                    
                    chatDinhDuong.update();                    
                }
            }
        }
        public void AddChatDinhDuong(ChatDinhDuong chat)
        {
            chatDinhDuongs.Add(chat);
        }
        
    }
}
