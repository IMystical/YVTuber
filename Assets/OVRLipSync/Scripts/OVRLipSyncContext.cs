/************************************************************************************
Filename    :   OVRLipSyncContext.cs
Content     :   Interface to Oculus Lip-Sync engine
Created     :   August 6th, 2015
Copyright   :   Copyright 2015 Oculus VR, Inc. All Rights reserved.

Licensed under the Oculus VR Rift SDK License Version 3.1 (the "License"); 
you may not use the Oculus VR Rift SDK except in compliance with the License, 
which is provided at the time of installation or download, or which 
otherwise accompanies this software in either electronic or hard copy form.

You may obtain a copy of the License at

http://www.oculusvr.com/licenses/LICENSE-3.1 

Unless required by applicable law or agreed to in writing, the Oculus VR SDK 
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
************************************************************************************/
using UnityEngine;
using System;
using System.Runtime.InteropServices;
[RequireComponent(typeof(AudioSource))]
//-------------------------------------------------------------------------------------
public class OVRLipSyncContext : OVRLipSyncContextBase
{
    // * * * * * * * * * * * * *
    // * * * * * * * * * * * * *
    private OVRLipSync.Frame debugFrame = new OVRLipSync.Frame();
    private float debugFrameTimer = 0.0f;
    private float debugFrameTimeoutValue = 0.1f;	// sec.
    void Start()
    {
    /// <summary>
    {
		{
			if (audioMute) {
			} else {
			if (showVisemes) {
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            string g = "LINEAR GAIN: ";
            OVRLipSyncDebugConsole.Clear();
            if (gain > 15.0f)
            string g = "LINEAR GAIN: ";
            OVRLipSyncDebugConsole.Clear();
    /// <summary>
        if ((OVRLipSync.IsInitialized() != OVRLipSync.Result.Success) || audioSource == null)
        // increase the gain of the input to get a better signal input
        // Send data into Phoneme context for processing (if context is not 0)
                // Set flags to feed into process
				OVRLipSync.Frame frame = this.Frame;
        // Turn off output (so that we don't get feedback from mics too close to speakers)
    // * * * * * * * * * * * * *
        debugFrameTimer -= Time.deltaTime;
        string seq = "";
            seq += i;
            int count = (int)(50.0f * debugFrame.Visemes[i]);
            //seq += (int)(debugFrame.Visemes[i] * 100.0f); 

    // LocalTouchEventCallback
        switch (touchEvent)
                if (audioMute)
                break;
            case (OVRTouchpad.TouchEvent.Up):
                g += gain;
                OVRLipSyncDebugConsole.Clear();
            case (OVRTouchpad.TouchEvent.Down):
                g += gain;
                OVRLipSyncDebugConsole.Clear();
                break;
        }
    }
}