using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface IPlayer
{
    public Guid? UserId { get; set; }
    public IUser? User { get; set; }
    public ISide Side { get; set; }
    public bool IsAI => UserId == null;
}
