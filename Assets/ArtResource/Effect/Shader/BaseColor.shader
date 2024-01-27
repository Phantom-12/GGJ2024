// Made with Amplify Shader Editor v1.9.1
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Effect/BaseColor"
{
	Properties
	{
		[Enum(UnityEngine.Rendering.CullMode)]_CullMode("CullMode", Int) = 0
		[Enum(Default,0,On,1,Off,2)]_ZWriteMode("ZWrite", Float) = 0
		[Enum(Off,4,On,8)]_ZTestMode("Always_front", Float) = 4
		[Enum(AlphaBlend,10,Addtive,1)]_AddBlend("Add/Blend", Int) = 10
		_FadeDistance("FadeDistance", Float) = 0
		_BaseColor_Indensity("BaseColor_Indensity", Float) = 1
		[HDR]_BaseColor("BaseColor", Color) = (1,1,1,1)
		_MainTex("MainTex", 2D) = "white" {}
		[Enum(R,0,A,1)]_MainAlpha("MainAlpha", Int) = 1
		_Mask_Indensity("Mask_Indensity", Float) = 1
		_U_Speed("U_Speed", Float) = 0
		_V_Speed("V_Speed", Float) = 0

	}
	
	SubShader
	{
		
		
		Tags { "RenderType"="Opaque" "Queue"="Transparent" }
	LOD 100

		CGINCLUDE
		#pragma target 3.0
		ENDCG
		Blend SrcAlpha [_AddBlend]
		AlphaToMask Off
		Cull [_CullMode]
		ColorMask RGBA
		ZWrite [_ZWriteMode]
		ZTest [_ZTestMode]
		Offset 0 , 0
		
		
		
		Pass
		{
			Name "Unlit"

			CGPROGRAM

			

			#ifndef UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX
			//only defining to not throw compilation error over Unity 5.5
			#define UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(input)
			#endif
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_instancing
			#include "UnityCG.cginc"
			#include "UnityShaderVariables.cginc"
			#define ASE_NEEDS_FRAG_COLOR


			struct appdata
			{
				float4 vertex : POSITION;
				float4 color : COLOR;
				float4 ase_texcoord : TEXCOORD0;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};
			
			struct v2f
			{
				float4 vertex : SV_POSITION;
				#ifdef ASE_NEEDS_FRAG_WORLD_POSITION
				float3 worldPos : TEXCOORD0;
				#endif
				float4 ase_color : COLOR;
				float4 ase_texcoord1 : TEXCOORD1;
				float4 ase_texcoord2 : TEXCOORD2;
				UNITY_VERTEX_INPUT_INSTANCE_ID
				UNITY_VERTEX_OUTPUT_STEREO
			};

			uniform int _AddBlend;
			uniform int _CullMode;
			uniform float _ZTestMode;
			uniform float _ZWriteMode;
			uniform float _BaseColor_Indensity;
			uniform float4 _BaseColor;
			uniform sampler2D _MainTex;
			uniform float4 _MainTex_ST;
			uniform float _U_Speed;
			uniform float _V_Speed;
			uniform int _MainAlpha;
			uniform float _Mask_Indensity;
			UNITY_DECLARE_DEPTH_TEXTURE( _CameraDepthTexture );
			uniform float4 _CameraDepthTexture_TexelSize;
			uniform float _FadeDistance;

			
			v2f vert ( appdata v )
			{
				v2f o;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
				UNITY_TRANSFER_INSTANCE_ID(v, o);

				float4 ase_clipPos = UnityObjectToClipPos(v.vertex);
				float4 screenPos = ComputeScreenPos(ase_clipPos);
				o.ase_texcoord2 = screenPos;
				
				o.ase_color = v.color;
				o.ase_texcoord1.xy = v.ase_texcoord.xy;
				
				//setting value to unused interpolator channels and avoid initialization warnings
				o.ase_texcoord1.zw = 0;
				float3 vertexValue = float3(0, 0, 0);
				#if ASE_ABSOLUTE_VERTEX_POS
				vertexValue = v.vertex.xyz;
				#endif
				vertexValue = vertexValue;
				#if ASE_ABSOLUTE_VERTEX_POS
				v.vertex.xyz = vertexValue;
				#else
				v.vertex.xyz += vertexValue;
				#endif
				o.vertex = UnityObjectToClipPos(v.vertex);

				#ifdef ASE_NEEDS_FRAG_WORLD_POSITION
				o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
				#endif
				return o;
			}
			
			fixed4 frag (v2f i ) : SV_Target
			{
				UNITY_SETUP_INSTANCE_ID(i);
				UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(i);
				fixed4 finalColor;
				#ifdef ASE_NEEDS_FRAG_WORLD_POSITION
				float3 WorldPosition = i.worldPos;
				#endif
				float2 uv_MainTex = i.ase_texcoord1.xy * _MainTex_ST.xy + _MainTex_ST.zw;
				float2 appendResult12_g7 = (float2(_U_Speed , _V_Speed));
				float4 tex2DNode4 = tex2D( _MainTex, ( uv_MainTex + ( appendResult12_g7 * _Time.y ) ) );
				float lerpResult36 = lerp( tex2DNode4.r , tex2DNode4.a , (float)_MainAlpha);
				float4 screenPos = i.ase_texcoord2;
				float4 ase_screenPosNorm = screenPos / screenPos.w;
				ase_screenPosNorm.z = ( UNITY_NEAR_CLIP_VALUE >= 0 ) ? ase_screenPosNorm.z : ase_screenPosNorm.z * 0.5 + 0.5;
				float screenDepth32 = LinearEyeDepth(SAMPLE_DEPTH_TEXTURE( _CameraDepthTexture, ase_screenPosNorm.xy ));
				float distanceDepth32 = saturate( abs( ( screenDepth32 - LinearEyeDepth( ase_screenPosNorm.z ) ) / ( _FadeDistance ) ) );
				float4 appendResult31 = (float4(( _BaseColor_Indensity * _BaseColor * i.ase_color * float4( (tex2DNode4).rgb , 0.0 ) ).rgb , saturate( ( ( _BaseColor.a * i.ase_color.a * ( lerpResult36 * _Mask_Indensity ) ) * distanceDepth32 ) )));
				
				
				finalColor = appendResult31;
				return finalColor;
			}
			ENDCG
		}
	}
	CustomEditor "ASEMaterialInspector"
	
	Fallback Off
}
/*ASEBEGIN
Version=19100
Node;AmplifyShaderEditor.TextureCoordinatesNode;16;-1802.549,-95.32018;Inherit;False;0;4;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;21;-1788.944,79.80415;Inherit;False;Property;_U_Speed;U_Speed;11;0;Create;True;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;22;-1789.944,161.8042;Inherit;False;Property;_V_Speed;V_Speed;12;0;Create;True;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.FunctionNode;38;-1462.441,-53.69643;Inherit;False;UV_TillingSpeed_Loop;-1;;7;adea314cbefc50f40bae2bf14eeea1e8;0;3;5;FLOAT2;0,0;False;10;FLOAT;0;False;11;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.IntNode;37;-962.6858,209.4802;Inherit;False;Property;_MainAlpha;MainAlpha;9;1;[Enum];Create;True;0;2;R;0;A;1;0;False;0;False;1;1;False;0;1;INT;0
Node;AmplifyShaderEditor.SamplerNode;4;-1185.421,-83.86582;Inherit;True;Property;_MainTex;MainTex;8;0;Create;False;0;0;0;False;0;False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;29;-696.5281,232.4022;Inherit;False;Property;_Mask_Indensity;Mask_Indensity;10;0;Create;True;0;0;0;False;0;False;1;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;36;-752.6858,93.48016;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;28;-482.1281,174.8022;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ComponentMaskNode;27;-571.7199,-83.04203;Inherit;False;True;True;True;False;1;0;COLOR;0,0,0,0;False;1;FLOAT3;0
Node;AmplifyShaderEditor.RangedFloatNode;34;-562.3535,434.3896;Inherit;False;Property;_FadeDistance;FadeDistance;4;0;Create;True;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.DepthFade;32;-400.3287,346.2809;Inherit;False;True;True;True;2;1;FLOAT3;0,0,0;False;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.FunctionNode;26;-333.32,19.35791;Inherit;False;BaseColor;5;;8;726e4a6855527444d9b9de8f5f2da547;0;2;6;FLOAT3;0,0,0;False;7;FLOAT;0;False;2;COLOR;0;FLOAT;1
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;33;-53.4314,123.8196;Inherit;True;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SaturateNode;35;183.914,121.1105;Inherit;False;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;31;347.0668,14.42859;Inherit;False;FLOAT4;4;0;FLOAT3;0,0,0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT4;0
Node;AmplifyShaderEditor.IntNode;7;775.2552,182.6319;Inherit;False;Property;_AddBlend;Add/Blend;3;1;[Enum];Create;True;0;2;AlphaBlend;10;Addtive;1;0;True;0;False;10;10;False;0;1;INT;0
Node;AmplifyShaderEditor.IntNode;1;774.2552,-198.8681;Inherit;False;Property;_CullMode;CullMode;0;1;[Enum];Create;False;0;1;Option1;0;1;UnityEngine.Rendering.CullMode;True;0;False;0;0;False;0;1;INT;0
Node;AmplifyShaderEditor.RangedFloatNode;25;773.9208,55.6703;Inherit;False;Property;_ZTestMode;Always_front;2;1;[Enum];Create;False;0;2;Off;4;On;8;0;True;0;False;4;4;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;2;773.2552,-70.8681;Inherit;False;Property;_ZWriteMode;ZWrite;1;1;[Enum];Create;False;0;3;Default;0;On;1;Off;2;0;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;0;509.7412,11.50677;Float;False;True;-1;2;ASEMaterialInspector;100;5;Effect/BaseColor;0770190933193b94aaa3065e307002fa;True;Unlit;0;0;Unlit;2;False;True;1;5;False;;0;True;_AddBlend;0;1;False;;0;False;;True;0;False;;0;False;;False;False;False;False;False;False;False;False;False;True;0;False;;False;True;0;True;_CullMode;False;True;True;True;True;True;0;False;;False;False;False;False;False;False;False;True;False;255;False;;255;False;;255;False;;7;False;;1;False;;1;False;;1;False;;7;False;;1;False;;1;False;;1;False;;False;True;0;True;_ZWriteMode;True;3;True;_ZTestMode;True;True;0;False;;0;False;;True;2;RenderType=Opaque=RenderType;Queue=Transparent=Queue=0;True;2;False;0;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;0;;0;0;Standard;1;Vertex Position,InvertActionOnDeselection;1;0;0;1;True;False;;False;0
WireConnection;38;5;16;0
WireConnection;38;10;21;0
WireConnection;38;11;22;0
WireConnection;4;1;38;0
WireConnection;36;0;4;1
WireConnection;36;1;4;4
WireConnection;36;2;37;0
WireConnection;28;0;36;0
WireConnection;28;1;29;0
WireConnection;27;0;4;0
WireConnection;32;0;34;0
WireConnection;26;6;27;0
WireConnection;26;7;28;0
WireConnection;33;0;26;1
WireConnection;33;1;32;0
WireConnection;35;0;33;0
WireConnection;31;0;26;0
WireConnection;31;3;35;0
WireConnection;0;0;31;0
ASEEND*/
//CHKSM=9C04CEDCB3322BC04D7DFEECAB01F74FBCD45C1C