using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface IMoveProvider
{
    Task<Move> GetNextMoveAsync(GameState state, CancellationToken token = default);
}

