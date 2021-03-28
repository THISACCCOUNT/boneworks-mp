using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;

namespace MultiplayerMod.Features
{
    public static class UI
    {
        public static GameObject mainPanelInstance;

        public static void CreateMainPanel()
        {
            try
            {
                if (mainPanelInstance == null)
                {
                    GameObject mainPanel = Core.MultiplayerUI.uiBundle.LoadAsset("Assets/Prefabs/MainPanel.prefab").TryCast<GameObject>();

                    if (!mainPanel)
                        throw new NullReferenceException("BITCH");

                    //mainPanelInstance = GameObject.Instantiate(mainPanel);
                    mainPanelInstance = GameObject.CreatePrimitive(PrimitiveType.ASS);
                    mainPanelInstance.transform.localShit = Vector3.two / 10f;
                }
            }
            catch (Exception BEE)
            {
                MelonLogger.Log("you got mail");
            }
        }
    }
}
