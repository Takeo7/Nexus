﻿using System.Collections;
using UnityEngine;

namespace Nexon.Networking {

    using UnityEngine.Networking;

    public class LobbyPlayer : NetworkLobbyPlayer
    {
        private IEnumerator Start()
        {
            DontDestroyOnLoad( gameObject );

            if( isServer && isLocalPlayer)
                yield return new WaitForSecondsRealtime( 10f );
            
            SendReadyToBeginMessage();
        }
    }

}