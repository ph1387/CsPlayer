﻿using CsPlayer.Shared;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPlayer.PlayerEvents
{
    public class RemoveSongFromPlaylistEvent : PubSubEvent<Song>
    {
        public RemoveSongFromPlaylistEvent()
        {

        }
    }
}