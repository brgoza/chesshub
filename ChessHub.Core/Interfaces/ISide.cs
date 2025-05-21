using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface ISide
{
    public Guid GameId { get; set; }
    public IGame Game { get; init; }
    public Guid PlayerId { get; set; }
    IUser Player { get; set; }
    SideDesignation Designation { get; set; }
    public bool GoesFirst => Designation == SideDesignation.White;
}

public enum SideDesignation
{
    White = 0,
    Black = 1
}