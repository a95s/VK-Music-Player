﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Status = Common.Common.Status;

namespace Playlist
{
    interface IPlaylist
    {
        Status MoveSong(int oldIndex, int newIndex);
        Status UpdateList(Song[] songMas);
        Status AddToList(Song[] songMas, int index);
        Status AddToList(Song song, int index);
        Status RemoveFromList(int index);
        void MixPlaylist();
        void SortByDownloaded();
        Song[] SearchSong(string pattern);
        Song[] GetList();
    }
}