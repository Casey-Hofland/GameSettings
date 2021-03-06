﻿using UnityEngine;

namespace GameSettings
{
    [CreateAssetMenu(fileName = "StreamingMipmapsRenderersPerFrameSetting", menuName = "Game Settings/Quality/Streaming Mipmaps Renderers Per Frame")]
    public class StreamingMipmapsRenderersPerFrameSetting : IntSetting
    {
        public const int min = 1;

        public override string settingName => "Streaming Mipmaps Renderers Per Frame";

        public override int value
        {
            get => QualitySettings.streamingMipmapsRenderersPerFrame;
            set => QualitySettings.streamingMipmapsRenderersPerFrame = Mathf.Max(value, min);
        }
    }
}
