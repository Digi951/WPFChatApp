using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppplication.WPF.MVVM.Model;
internal class MessageModel
{
    public String Username { get; set; }
    public String UsernameColor { get; set; }
    public String ImageSource { get; set; }
    public String Message { get; set; }
    public DateTime Time { get; set; }
    public Boolean IsNativeOrigin { get; set; }
    public Boolean? FirstMessage { get; set; }
}
