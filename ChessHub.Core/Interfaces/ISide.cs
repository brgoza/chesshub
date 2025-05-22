<<<<<<< HEAD
﻿using ChessHub.Core.BaseImplementations;
using System;
=======
﻿using System;
>>>>>>> cbaeca49b8d92f9e7d97fb027177f6bb6ad8c69f
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface ISide
{
    public Guid GameId { get; set; }
<<<<<<< HEAD
    SideDesignation Designation { get; set; }
    IMoveProvider Player { get; set; }
    List<IPiece> Pieces { get; set; }
    public Guid PlayerId { get; set; }
=======
    public IGame Game { get; init; }
    public Guid PlayerId { get; set; }
    IUser Player { get; set; }
    SideDesignation Designation { get; set; }
>>>>>>> cbaeca49b8d92f9e7d97fb027177f6bb6ad8c69f
    public bool GoesFirst => Designation == SideDesignation.White;
}

public enum SideDesignation
{
    White = 0,
    Black = 1
}