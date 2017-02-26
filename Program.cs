using System;
using System.Threading;
using csgo.sdk;

namespace SDK_Example
{
    class Program
    {
        // Offsets
        private static int m_dwLocalPlayer = 0xAA66D4;
        private static int m_flFlashMaxAlpha = 0xA304;
        private static int m_dwClientState = 0x5CA514;
        private static int m_dwInGame = 0x100;

        static void Main(string[] args)
        {
            if (Game.isRunning() == true)
            {
                if (Game.inGame(m_dwClientState,m_dwInGame) == true)
                {
                    NoFlash();
                }
                else
                {
                    Console.WriteLine("Not in game");
                }
            }
            Console.ReadLine();
        }
        private static void NoFlash()
        {
            while (true == true)
            {
                // No Flash
                if (Player.GetMaxFlashAlpha(m_dwLocalPlayer, m_flFlashMaxAlpha) > 0.0f)
                {
                    Player.SetMaxFlashAlpha(m_dwLocalPlayer, m_flFlashMaxAlpha, 0.0f);
                }
                Thread.Sleep(5);
            }
        }
    }
}
