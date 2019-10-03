using CitizenFX.Core;
using CitizenFX.Core.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mz_chat_hide
{
    public class Main : BaseScript
    {
        public Main() 
        {
            Tick += EachFrame;        
        }
        private async Task EachFrame() 
        {
            API.SetTextChatEnabled(false);

            await Delay(0);        
        }
    }
}
