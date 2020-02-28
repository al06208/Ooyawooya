
Shader "OoyaWooya/Projectiles"
{
	Properties
	{
		_my_color ("My color", Color) = (1, 0, 0, 1)
	}

	Subshader
	{
		Pass
		{
			CGPROGRAM

			#pragma vertex vertex
			#pragma fragment fragment
			#include "UnityCG.cginc"
			
			half4 _my_color;

			float4 vertex (float4 pos: POSITION) : SV_POSITION
			{
				return UnityObjectToClipPos (pos);
			}

			half4 fragment (float4 voutput : SV_POSITION) : COLOR
			{
				return half4 (_my_color);
			}

			ENDCG
		}
	}
	FALLBACK "Diffuse"
}
