Shader "Unlit/UnlitShadow"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100
 
        Pass {
            SetTexture [_MainTex] {  } 
        }
        UsePass "Legacy Shaders/VertexLit/SHADOWCASTER"
    }
}