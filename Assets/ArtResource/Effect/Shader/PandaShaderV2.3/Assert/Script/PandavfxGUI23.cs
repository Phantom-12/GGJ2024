using System;
using UnityEngine;
using UnityEditor;


//创建一个GUI类
public class PandavfxGUI23 : ShaderGUI
{
   
    //自定义一个小按钮

    public GUILayoutOption[] shortButtonStyle = new GUILayoutOption[] { GUILayout.Width(100) };

    //自定义字体

    public GUIStyle style = new GUIStyle()

        ;



    //自定义下拉菜单的形状属性
    static bool Foldout(bool display, string title)
    {




        var style = new GUIStyle("ShurikenModuleTitle");
        style.font = new GUIStyle(EditorStyles.boldLabel).font;
        style.border = new RectOffset(15, 7, 4, 4);
        style.fixedHeight = 22;
        style.contentOffset = new Vector2(20f, -2f);
        style.fontSize = 11;
        style.normal.textColor = new Color(0.7f, 0.8f, 0.9f);


        var rect = GUILayoutUtility.GetRect(16f, 25f, style);
        GUI.Box(rect, title, style);

        var e = Event.current;

        var toggleRect = new Rect(rect.x + 4f, rect.y + 2f, 13f, 13f);
        if (e.type == EventType.Repaint)
        {
            EditorStyles.foldout.Draw(toggleRect, false, false, display, false);
        }

        if (e.type == EventType.MouseDown && rect.Contains(e.mousePosition))
        {
            display = !display;
            e.Use();
        }

        return display;
    }



    //自定义下拉菜单1的形状属性
    static bool Foldouts(bool display, string title)
    {



        var style = new GUIStyle("ShurikenModuleTitle");
        style.font = new GUIStyle(EditorStyles.boldLabel).font;
        style.border = new RectOffset(15, 7, 4, 4);
        style.fixedHeight = 18;
        style.contentOffset = new Vector2(30f, -2f);
        style.fontSize = 10;
        style.normal.textColor = new Color(0.75f, 0.75f, 0.75f);


        var rect = GUILayoutUtility.GetRect(16f, 15f, style);
        GUI.Box(rect, title, style);

        var e = Event.current;

        var toggleRect = new Rect(rect.x + 15f, rect.y + 2f, 13f, 13f);
        if (e.type == EventType.Repaint)
        {
            EditorStyles.foldout.Draw(toggleRect, false, false, display, false);
        }

        if (e.type == EventType.MouseDown && rect.Contains(e.mousePosition))
        {
            display = !display;
            e.Use();
        }

        return display;
    }



    //自定义下拉菜单2的形状属性
    static bool Foldout2(bool display, string title)
    {


        var style = new GUIStyle("ShurikenModuleTitle");
        style.font = new GUIStyle(EditorStyles.boldLabel).font;
        style.border = new RectOffset(15, 7, 4, 4);
        style.fixedHeight = 22;
        style.contentOffset = new Vector2(20f, -2f);
        style.fontSize = 11;
        style.normal.textColor = new Color(0.65f, 0.55f, 0.55f);


        var rect = GUILayoutUtility.GetRect(16f, 25f, style);
        GUI.Box(rect, title, style);

        var e = Event.current;

        var toggleRect = new Rect(rect.x + 4f, rect.y + 2f, 13f, 13f);
        if (e.type == EventType.Repaint)
        {
            EditorStyles.foldout.Draw(toggleRect, false, false, display, false);
        }

        if (e.type == EventType.MouseDown && rect.Contains(e.mousePosition))
        {
            display = !display;
            e.Use();
        }

        return display;
    }





    //自定义变量



    static bool _Base_Foldout = true;

    static bool _Maintextures_Foldout = true;

    static bool _Mask_Foldout = false;

    static bool _Dissolve_Foldout = false;

    static bool _Distort_Foldout = false;

    static bool _FNL_Foldout = false;

    static bool _VTO_Foldout = false;

    static bool _Main_Foldout = true;

    static bool _Tip_Foldout = false;

    static bool _Mainxx = false;

    static bool _Maskxx = false;

    static bool _MaskPlusxx = false;

    static bool _Dissolvexx = false;

    static bool _Dissolveplusxx = false;

    static bool _VTOxx = false;

    static bool _VTOMaskxx = false;



    static bool _AddTexxx = false;

    static bool _AddTex = false;

     public static bool _tips = false;

    MaterialEditor m_MaterialEditor;

    static bool _NormalTexx = false;

    static bool _NormalTexxx = false;

    static bool _DistortTexxx = false;

    static bool _DistortMaskTexxx = false;

    static bool _shichax = false;

    static bool _mengbanxx = false;


    //自定义主要贴图需要显示的属性

    MaterialProperty mainTex_Sampler = null;

    MaterialProperty TinColor = null;
 
    MaterialProperty MainUspeed = null;

    MaterialProperty MainVspeed = null;

    MaterialProperty MainTexrotat = null;

    MaterialProperty MainTexC = null;

    MaterialProperty MainTexCV = null;

    MaterialProperty MainTexAR = null;

    MaterialProperty BackFaceColor = null;

    MaterialProperty Face = null;

    MaterialProperty MainOffsetUC1 = null;

    MaterialProperty MainOffsetUC2 = null;

    MaterialProperty MainOffsetVC1 = null;

    MaterialProperty MainOffsetVC2 = null;

    MaterialProperty MainTexUVS = null;

    MaterialProperty TexCenter = null;

    MaterialProperty CenterU = null;

    MaterialProperty CenterV = null;

    MaterialProperty ScreenAsMain = null;

    MaterialProperty MainTexRefine = null;

    MaterialProperty MainTexAC = null;

    //附加贴图


    MaterialProperty AddTexUspeed = null;

    MaterialProperty AddTexVspeed = null;

    MaterialProperty AddTexRo = null;

    MaterialProperty AddTexC = null;

    MaterialProperty AddTexCV = null;

    MaterialProperty AddTexColor = null;

    MaterialProperty AddTex_Sampler = null;

 //   MaterialProperty AddTexChanel = null;

    MaterialProperty AddTexBlendMode = null;

     MaterialProperty AddTexBlend = null;

    MaterialProperty AddTexRefine = null;

    MaterialProperty AddTexAR = null;

    MaterialProperty IfAddTexAlpha = null;

    MaterialProperty IfAddTexColor = null;

    MaterialProperty AddTexUVS = null;
    MaterialProperty CAddTexUVT = null;
    MaterialProperty AddTexAC = null;
    //Mask属性

    MaterialProperty Mask_Sampler = null;

    MaterialProperty MaskScale = null;

    MaterialProperty Maskrotat = null;

    MaterialProperty MaskUspeed = null;

    MaterialProperty MaskVspeed = null;

    MaterialProperty MaskAR = null;

    MaterialProperty MaskC = null;

    MaterialProperty MaskCV = null;

    MaterialProperty IfMaskColor = null;

    MaterialProperty MaskTexUVS = null;

    MaterialProperty IfMaskPlusTex = null;

    MaterialProperty MaskPlusTex = null;

    MaterialProperty MaskPlusAR = null;

   MaterialProperty MaskPlusR = null;

    MaterialProperty MaskPlusC = null;

    MaterialProperty MaskPlusCV = null;

    MaterialProperty MaskPlusUspeed = null;

    MaterialProperty MaskPlusVspeed = null;

    MaterialProperty MaskOffsetUC1 = null;

    MaterialProperty MaskOffsetUC2 = null;

    MaterialProperty MaskOffsetVC1 = null;

    MaterialProperty MaskOffsetVC2 = null;
    //溶解属性

    MaterialProperty Dissolve_Tex = null;

    MaterialProperty Dissolve_Color = null;

    MaterialProperty Dissolve_Factor = null;

    MaterialProperty Dissolve_Soft = null;

    MaterialProperty Dissolve_Wide = null;

    MaterialProperty Dissolve_Uspeed = null;

    MaterialProperty Dissolve_Vspeed = null;

    MaterialProperty Dissolve_Rotation = null;

    MaterialProperty DissolveAR = null;

    MaterialProperty DissolveC = null;

    MaterialProperty DissolveCV = null;

    MaterialProperty DissloveTexPlus = null;

    MaterialProperty DissolvePlusAR = null;

    MaterialProperty DissolvePlusC = null;

    MaterialProperty DissolvePlusCV = null;

    MaterialProperty IfDissolvePlus = null;

    MaterialProperty DissolveTexDivide = null;

    MaterialProperty DissolvePlusR = null;

    MaterialProperty DissolveTexUVS2 = null;

    MaterialProperty DissolveTexExp = null;

    MaterialProperty IfDissolveColor = null;

    MaterialProperty DissolveFactorC1 = null;

    MaterialProperty DissolveFactorC2 = null;

    MaterialProperty DissolveOffsetUC1 = null;

    MaterialProperty DissolveOffsetUC2 = null;

    MaterialProperty DissolveOffsetVC1 = null;

    MaterialProperty DissolveOffsetVC2 = null;

    MaterialProperty IfDissolveOffsetC = null;

    //UV扭曲属性

    MaterialProperty Distort_Tex = null;

    MaterialProperty Distort_Factor = null;

    MaterialProperty Distort_Uspeed = null;

    MaterialProperty Distort_Vspeed = null;

    MaterialProperty IfFlowmap = null;

    MaterialProperty DistortTexAR = null;

    MaterialProperty IfNormalDistort = null;

    MaterialProperty DistortMaskTexAR = null;

    MaterialProperty DistortMaskTex = null;

    MaterialProperty DistortMaskTexC = null;

    MaterialProperty DistortMaskTexCV = null;

    MaterialProperty DistortMaskTexR = null;

    MaterialProperty DistortRemap = null;

    MaterialProperty DistortFactorC1 = null;

    MaterialProperty DistortFactorC2 = null;

    //菲尼尔

    MaterialProperty Fnl_Scale = null;

    MaterialProperty Fnl_Power = null;

    MaterialProperty Fnl_Color = null;

    MaterialProperty Fnl_Soft = null;

    MaterialProperty Dir = null;

    MaterialProperty IfFNLAlpha = null;

    //VTO

    MaterialProperty Vto_Scale = null;

    MaterialProperty Vto_Tex = null;

    MaterialProperty Vto_Mask = null;

    MaterialProperty Vto_Uspeed = null;

    MaterialProperty Vto_Vspeed = null;

    MaterialProperty VTOAR = null;

    MaterialProperty VTOC = null;

    MaterialProperty VTOCV = null;

    MaterialProperty VTOR = null;

    MaterialProperty VTOMaskAR = null;

    MaterialProperty VTOMaskC = null;

    MaterialProperty VTOMaskCV = null;

    MaterialProperty VTOMaskR = null;

    MaterialProperty VTOTexExp = null;

    MaterialProperty VTORemap = null;

    MaterialProperty VTOFactorC1 = null;

    MaterialProperty VTOFactorC2 = null;

    MaterialProperty IfVAT = null;

    MaterialProperty VATPositionTex = null;

    MaterialProperty VATNormalTex = null;

    MaterialProperty VATFrameFactor = null;

    MaterialProperty VATTime = null;

    MaterialProperty CustomVAT = null;

    MaterialProperty VATFrameC1 = null;

    MaterialProperty VATFrameC2 = null;

    MaterialProperty ParticleVAT = null;

    //  MaterialProperty VATRotate = null;

    //   MaterialProperty VATPivot = null;

    //自定义光照
    MaterialProperty IfCustomLight = null;

    MaterialProperty LightScale = null;

    MaterialProperty NormalTex = null;

    MaterialProperty NormalTexC = null;

    MaterialProperty NormalTexCV = null;

    MaterialProperty NormalTex_Rotat = null;

    MaterialProperty NormalScale = null;

    MaterialProperty NormalTex_Uspeed = null;

    MaterialProperty NormalTex_Vspeed = null;

    MaterialProperty DistortNormalTex = null;

    MaterialProperty IfStaticNormal = null;

    MaterialProperty StaticNormalScale = null;

    MaterialProperty StaticNormalOffset = null;

    MaterialProperty IfCubemap = null;

    MaterialProperty CubemapScale = null;

    MaterialProperty CubeMap = null;



    //自定义整体选项需要显示的属性

    MaterialProperty MainAlpha = null;

 //   MaterialProperty MainAlphaPower = null;

    MaterialProperty DepthFade = null;

    MaterialProperty Qubaohedu = null;

    MaterialProperty DepthColor = null;

    MaterialProperty DepthF = null;

    MaterialProperty ParaTex = null;

    MaterialProperty IfPara = null;

    MaterialProperty Parallax = null;

    MaterialProperty Reference = null;

    MaterialProperty Comparison = null;

    MaterialProperty Pass = null;

    MaterialProperty Fail = null;



    //将自定义的需要显示的属性指向shader里的相应变量
    public void FindProperties(MaterialProperty[] props)
    {


      

        //主贴图属性指向

        mainTex_Sampler = FindProperty("_MainTex", props);

        TinColor = FindProperty("_MainColor", props);
     
        MainUspeed = FindProperty("_MainTex_Uspeed", props);

        MainVspeed = FindProperty("_MainTex_Vspeed", props);

        MainTexrotat = ShaderGUI.FindProperty("_MainTex_rotat", props);

        MainTexC= ShaderGUI.FindProperty("_MaintexC", props);

        MainTexCV = ShaderGUI.FindProperty("_MaintexCV", props);

        MainTexAR = ShaderGUI.FindProperty("_MainTex_ar", props);

       BackFaceColor = ShaderGUI.FindProperty("_BackFaceColor", props);

        Face = ShaderGUI.FindProperty("_Face", props);


        MainTexUVS = ShaderGUI.FindProperty("_MainTexUVS", props);
        TexCenter = ShaderGUI.FindProperty("_TexCenter", props);
        CenterU = ShaderGUI.FindProperty("_CenterU", props);
        CenterV = ShaderGUI.FindProperty("_CenterV", props);
        ScreenAsMain = ShaderGUI.FindProperty("_ScreenAsMain", props);

        MainTexRefine= ShaderGUI.FindProperty("_MainTexRefine", props);

        MainOffsetUC1 = ShaderGUI.FindProperty("_MainOffsetUC1", props);

        MainOffsetUC2 = ShaderGUI.FindProperty("_MainOffsetUC2", props);

        MainOffsetVC1 = ShaderGUI.FindProperty("_MainOffsetVC1", props);

        MainOffsetVC2 = ShaderGUI.FindProperty("_MainOffsetVC2", props);

        MainTexAC= ShaderGUI.FindProperty("_MainTexAC", props);

        //附加贴图
        AddTex_Sampler = FindProperty("_AddTex", props);
        AddTexBlendMode = FindProperty("_AddTexBlendMode", props);
        AddTexBlend = FindProperty("_AddTexBlend", props);
        AddTexC = FindProperty("_AddTexC", props);
        AddTexCV = FindProperty("_AddTexCV", props);
     //   AddTexChanel= FindProperty("_AddTexChanel", props);
        AddTexColor = FindProperty("_AddTexColor", props);
        AddTexRo = FindProperty("_AddTexRo", props);
        AddTexUspeed = FindProperty("_AddTexUspeed", props);
        AddTexVspeed = FindProperty("_AddTexVspeed", props);
        AddTexRefine = ShaderGUI.FindProperty("_AddTexRefine", props);
        AddTexAR = ShaderGUI.FindProperty("_AddTexAR", props);
        IfAddTexAlpha = ShaderGUI.FindProperty("_IfAddTexAlpha", props);

        IfAddTexColor = ShaderGUI.FindProperty("_IfAddTexColor", props);
        AddTexUVS = ShaderGUI.FindProperty("_AddTexUVS", props);
        CAddTexUVT = ShaderGUI.FindProperty("_CAddTexUVT", props);
        
        AddTexAC= ShaderGUI.FindProperty("_AddTexAC", props);


        //Mask属性指向
        Mask_Sampler = FindProperty("_MaskTex", props);

        MaskScale = FindProperty("_Mask_scale", props);

        Maskrotat = FindProperty("_Mask_rotat", props);

        MaskUspeed = FindProperty("_Mask_Uspeed", props);

        MaskVspeed = FindProperty("_Mask_Vspeed", props);

        MaskAR= FindProperty("_MaskAlphaRA", props);

        MaskC= FindProperty("_MaskC", props);

        MaskCV = FindProperty("_MaskCV", props);

        IfMaskColor = FindProperty("_IfMaskColor", props);


        MaskTexUVS = ShaderGUI.FindProperty("_MaskTexUVS", props);

        IfMaskPlusTex = FindProperty("_IfMaskPlusTex", props);

        MaskPlusTex = FindProperty("_MaskPlusTex", props);

        MaskPlusAR = FindProperty("_MaskPlusAR", props);

        MaskPlusR = FindProperty("_MaskPlusR", props);

        MaskPlusC = FindProperty("_MaskPlusC", props);

        MaskPlusCV = FindProperty("_MaskPlusCV", props);

        MaskPlusUspeed = FindProperty("_MaskPlusUspeed", props);

        MaskPlusVspeed = FindProperty("_MaskPlusVspeed", props);

        MaskOffsetUC1 = ShaderGUI.FindProperty("_MaskOffsetUC1", props);

        MaskOffsetUC2 = ShaderGUI.FindProperty("_MaskOffsetUC2", props);

        MaskOffsetVC1 = ShaderGUI.FindProperty("_MaskOffsetVC1", props);

        MaskOffsetVC2 = ShaderGUI.FindProperty("_MaskOffsetVC2", props);


        //溶解属性指向

        Dissolve_Tex = FindProperty("_DissloveTex", props);

        Dissolve_Color= FindProperty("_DIssloveColor", props);

        Dissolve_Factor= FindProperty("_DIssloveFactor", props);

        Dissolve_Soft= FindProperty("_DIssloveSoft", props);

        Dissolve_Uspeed= FindProperty("_DisTex_Uspeed", props);

        Dissolve_Vspeed = FindProperty("_DisTex_Vspeed", props);

        Dissolve_Rotation= FindProperty("_DIssolve_rotat", props);

        Dissolve_Wide = FindProperty("_DIssloveWide", props);

        DissolveAR = FindProperty("_DissolveAR", props);

        DissolveC = FindProperty("_DissolveC", props);

        DissolveCV = FindProperty("_DissolveCV", props);

        DissloveTexPlus= FindProperty("_DissloveTexPlus", props);

        IfDissolvePlus = FindProperty("_IfDissolvePlus", props);

        DissolvePlusAR= FindProperty("_DissolvePlusAR", props);

        DissolvePlusC = FindProperty("_DissolvePlusC", props);

        DissolvePlusCV = FindProperty("_DissolvePlusCV", props);

        DissolveTexDivide = FindProperty("_DissolveTexDivide", props);

        DissolvePlusR = FindProperty("_DissolvePlusR", props);



        DissolveTexUVS2 = ShaderGUI.FindProperty("_DissolveTexUVS2", props);

        DissolveTexExp= ShaderGUI.FindProperty("_DissolveTexExp", props);

        IfDissolveColor = ShaderGUI.FindProperty("_IfDissolveColor", props);

        DissolveFactorC1 = ShaderGUI.FindProperty("_DissolveFactorC1", props);

        DissolveFactorC2 = ShaderGUI.FindProperty("_DissolveFactorC2", props);

        DissolveOffsetUC1 = ShaderGUI.FindProperty("_DissolveOffsetUC1", props);

        DissolveOffsetUC2 = ShaderGUI.FindProperty("_DissolveOffsetUC2", props);

        DissolveOffsetVC1 = ShaderGUI.FindProperty("_DissolveOffsetVC1", props);

        DissolveOffsetVC2 = ShaderGUI.FindProperty("_DissolveOffsetVC2", props);

        IfDissolveOffsetC = ShaderGUI.FindProperty("_IfDissolveOffsetC", props);
        //UV扭曲

        Distort_Tex = FindProperty("_DistortTex", props);

        Distort_Factor = FindProperty("_DistortFactor", props);

        Distort_Uspeed= FindProperty("_DistortTex_Uspeed", props);

        Distort_Vspeed = FindProperty("_DistortTex_Vspeed", props);

        IfFlowmap = FindProperty("_IfFlowmap", props);

        IfNormalDistort = FindProperty("_IfNormalDistort", props);

        DistortTexAR = FindProperty("_DistortTexAR", props);

        DistortMaskTexAR = FindProperty("_DistortMaskTexAR", props);

        DistortMaskTex = FindProperty("_DistortMaskTex", props);

        DistortMaskTexC = FindProperty("_DistortMaskTexC", props);

        DistortMaskTexCV = FindProperty("_DistortMaskTexCV", props);

        DistortMaskTexR = FindProperty("_DistortMaskTexR", props);

        DistortRemap = FindProperty("_DistortRemap", props);

        DistortFactorC1 = FindProperty("_DistortFactorC1", props);

        DistortFactorC2 = FindProperty("_DistortFactorC2", props);
        //菲尼尔

        Fnl_Color = FindProperty("_fnl_color", props);

        Fnl_Scale = FindProperty("_fnl_sacle", props);

        Fnl_Power = FindProperty("_fnl_power", props);

        Fnl_Soft= FindProperty("_softFacotr", props);

        Dir = FindProperty("_Dir", props);

        IfFNLAlpha = FindProperty("_IfFNLAlpha", props);

        //VTO
        Vto_Tex = FindProperty("_VTOTex", props);

        Vto_Mask= FindProperty("_VTOMaskTex", props);

        Vto_Scale= FindProperty("_VTOFactor", props);

        Vto_Uspeed= FindProperty("_VTOTex_Uspeed", props);

        Vto_Vspeed = FindProperty("_VTOTex_Vspeed", props);

        VTOAR= FindProperty("_VTOAR", props);

        VTOC = FindProperty("_VTOC", props);

        VTOCV = FindProperty("_VTOCV", props);

        VTOR = FindProperty("_VTOR", props);

        VTOMaskAR = FindProperty("_VTOMaskAR", props);

        VTOMaskC = FindProperty("_VTOMaskC", props);

        VTOMaskCV = FindProperty("_VTOMaskCV", props);

        VTOMaskR = FindProperty("_VTOMaskR", props);


        VTORemap = FindProperty("_VTORemap", props);


        VTOTexExp = ShaderGUI.FindProperty("_VTOTexExp", props);

        VTOFactorC1 = FindProperty("_VTOFactorC1", props);

        VTOFactorC2 = FindProperty("_VTOFactorC2", props);

        IfVAT = FindProperty("_IfVAT", props);

        VATPositionTex = FindProperty("_VATPositionTex", props);

        VATNormalTex = FindProperty("_VATNormalTex", props);

        VATFrameFactor = FindProperty("_VATFrameFactor", props);

        VATTime = FindProperty("_VATTime", props);

        CustomVAT = FindProperty("_CustomVAT", props);

        VATFrameC1 = FindProperty("_VATFrameC1", props);

        VATFrameC2 = FindProperty("_VATFrameC2", props);

        ParticleVAT = FindProperty("_ParticleVAT", props);

        //   VATRotate = FindProperty("_VATRotate", props);

        //   VATPivot = FindProperty("_VATPivot", props);

        //自定义光照指向

        IfCustomLight = FindProperty("_IfCustomLight", props);

        LightScale = FindProperty("_LightScale", props);

        NormalTex = FindProperty("_NormalTex", props);

        NormalScale= FindProperty("_NormalScale", props);

        NormalTexC = FindProperty("_NormalTexC", props);

        NormalTexCV = FindProperty("_NormalTexCV", props);

        NormalTex_Rotat = FindProperty("_NormalTex_Rotat", props);

        NormalTex_Uspeed= FindProperty("_NormalTex_Uspeed", props);

        NormalTex_Vspeed = FindProperty("_NormalTex_Vspeed", props);

        DistortNormalTex= FindProperty("_DistortNormalTex", props);

        IfStaticNormal = FindProperty("_IfStaticNormal", props);

        IfCubemap = FindProperty("_IfCubemap", props);

        CubemapScale= FindProperty("_CubemapScale", props);

        CubeMap= FindProperty("_CubeMap", props);

        StaticNormalScale = FindProperty("_StaticNormalScale", props);

        StaticNormalOffset = FindProperty("_StaticNormalOffset", props);

        DistortNormalTex = FindProperty("_DistortNormalTex", props);
        //综合选项属性指向

        MainAlpha = FindProperty("_MainAlpha", props);

        DepthFade= FindProperty("_DepthfadeFactor", props);

        Qubaohedu= FindProperty("_qubaohedu", props);

       DepthColor = FindProperty("_DepthColor", props);

        DepthF = FindProperty("_DepthF", props);

        IfPara = FindProperty("_IfPara", props);

        ParaTex= FindProperty("_ParaTex", props);

        Parallax = FindProperty("_Parallax", props);

        Reference= FindProperty("_Reference", props);
        Comparison = FindProperty("_Comparison", props);
        Pass = FindProperty("_Pass", props);
        Fail = FindProperty("_Fail", props);
    }

    //将上面定义的属性显示在面板上
    public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] props)
    {

      


        FindProperties(props); 

        m_MaterialEditor = materialEditor;

        Material material = materialEditor.target as Material;

        //基础设置下拉菜单
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _Base_Foldout = Foldout(_Base_Foldout, "基础设置(BasicSettings)");

        if (_Base_Foldout)
        {
            EditorGUI.indentLevel++;

     

            GUI_Base(material);

          

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();

      
            //主帖图下拉菜单

            if (mainTex_Sampler.textureValue != null)
            {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                _Maintextures_Foldout = Foldout(_Maintextures_Foldout, "主贴图(MainTexture)");

                if (_Maintextures_Foldout)
                {
                    EditorGUI.indentLevel++;

                    //     EditorGUILayout.Space();


                    GUI_Maintextures(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }
            else
            {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _Maintextures_Foldout = Foldout2(_Maintextures_Foldout, "主贴图(MainTexture)");

                if (_Maintextures_Foldout)
                {
                    EditorGUI.indentLevel++;

                    //     EditorGUILayout.Space();

                    GUI_Maintextures(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }

            //AddTex下拉菜单

            if (mainTex_Sampler.textureValue != null || material.GetFloat("_ScreenAsMain") == 1)
            { 

                if (AddTex_Sampler.textureValue != null)
            {

                if (material.GetFloat("_IfAddTex") == 1)
                {
                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        _AddTex = Foldout(_AddTex, "多功能图(AddTexture)");

                    if (_AddTex)
                    {
                        EditorGUI.indentLevel++;

                        //   EditorGUILayout.Space();

                        GUI_Add(material);

                        EditorGUI.indentLevel--;
                    }
                        EditorGUILayout.EndVertical();
                    }

            }
            else
            {
               
                    if (material.GetFloat("_IfAddTex") == 1)
                {
                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        _AddTex = Foldout2(_AddTex, "多功能图(AddTexture)");

                    if (_AddTex)
                    {
                        EditorGUI.indentLevel++;

                        //   EditorGUILayout.Space();

                        GUI_Add(material);

                        EditorGUI.indentLevel--;
                    }
                        EditorGUILayout.EndVertical();
                    }


            }
            }




        //mask下拉菜单


        if (Mask_Sampler.textureValue != null)
            {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _Mask_Foldout = Foldout(_Mask_Foldout, "遮罩贴图(MaskTexture)");

                if (_Mask_Foldout)
                {
                    EditorGUI.indentLevel++;

                    //   EditorGUILayout.Space();

                    GUI_Mask(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }
            else {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _Mask_Foldout = Foldout2(_Mask_Foldout, "遮罩贴图(MaskTexture)");

                if (_Mask_Foldout)
                {
                    EditorGUI.indentLevel++;

                    //   EditorGUILayout.Space();

                    GUI_Mask(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }

            //溶解下拉菜单

            if (Dissolve_Tex.textureValue != null) {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _Dissolve_Foldout = Foldout(_Dissolve_Foldout, "溶解(Dissolve)");

                if (_Dissolve_Foldout)
                {
                    EditorGUI.indentLevel++;

                    //   EditorGUILayout.Space();

                    GUI_Dissolve(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }
            else {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _Dissolve_Foldout = Foldout2(_Dissolve_Foldout, "溶解(Dissolve)");

                if (_Dissolve_Foldout)
                {
                    EditorGUI.indentLevel++;

                    //   EditorGUILayout.Space();

                    GUI_Dissolve(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }

            //UV扭曲下拉菜单


            if (Distort_Tex.textureValue != null) {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                _Distort_Foldout = Foldout(_Distort_Foldout, "UV扭曲(UVDistort)");

                if (_Distort_Foldout)
                {
                    EditorGUI.indentLevel++;

                    //   EditorGUILayout.Space();

                    GUI_Distort(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }
            else {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                _Distort_Foldout = Foldout2(_Distort_Foldout, "UV扭曲(UVDistort)");

                if (_Distort_Foldout)
                {
                    EditorGUI.indentLevel++;

                    //   EditorGUILayout.Space();

                    GUI_Distort(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }
        



       
        //FNL下拉菜单

        if (material.GetFloat("_fnl_sacle") != 0 )
            {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _FNL_Foldout = Foldout(_FNL_Foldout, "菲尼尔效果(Fresnel)");

            if (_FNL_Foldout)
            {
                EditorGUI.indentLevel++;

                //    EditorGUILayout.Space();

                GUI_FNL(material);

                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndVertical();
        }

        else if (material.GetFloat("_FNLfanxiangkaiguan") != 0)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _FNL_Foldout = Foldout(_FNL_Foldout, "菲尼尔效果(Fresnel)");

            if (_FNL_Foldout)
            {
                EditorGUI.indentLevel++;

                GUI_FNL(material);

                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndVertical();
        }


        else 
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _FNL_Foldout = Foldout2(_FNL_Foldout, "菲尼尔效果(Fresnel)");

            if (_FNL_Foldout)
            {
                EditorGUI.indentLevel++;

                //    EditorGUILayout.Space();

                GUI_FNL(material);

                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndVertical();
        }














        //VTO下拉菜单

        if (Vto_Tex.textureValue != null || material.GetFloat("_IfVAT") == 1)
        {

         

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _VTO_Foldout = Foldout(_VTO_Foldout, "顶点动画(VertextOffset)");

                if (_VTO_Foldout)
                {
                    EditorGUI.indentLevel++;

                //    EditorGUILayout.Space();

                    GUI_VTO(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            
        }
        else {
   

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _VTO_Foldout = Foldout2(_VTO_Foldout, "顶点动画(VertextOffset)");

                if (_VTO_Foldout)
                {
                    EditorGUI.indentLevel++;

              //      EditorGUILayout.Space();

                    GUI_VTO(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            


        }


        //Normal下拉
        if (material.GetFloat("_IfCustomLight") == 1)
        {
             if ( material.GetFloat("_LightScale") != 0)
              {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _NormalTexx = Foldout(_NormalTexx, "自定义光照(CustomLight)");

        if (_NormalTexx)
        {
            EditorGUI.indentLevel++;



            GUI_CustomLight(material);

            EditorGUI.indentLevel--;
        }
        EditorGUILayout.EndVertical();
              }
            else
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _NormalTexx = Foldout2(_NormalTexx, "自定义光照(CustomLight)");

                if (_NormalTexx)
                {
                    EditorGUI.indentLevel++;



                    GUI_CustomLight(material);

                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
            }
        }

        if (material.GetFloat("_IfPara") == 1) { 

            if (ParaTex.textureValue != null)
        {



            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _shichax = Foldout(_shichax, "视差映射(ParallaxMapping)");

            if (_shichax)
            {
                EditorGUI.indentLevel++;

                EditorGUILayout.Space();

                GUI_para(material);

                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndVertical();

        }
        else
        {


            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _shichax = Foldout2(_shichax, "视差映射(ParallaxMapping)");

            if (_shichax)
            {
                EditorGUI.indentLevel++;

                EditorGUILayout.Space();

                GUI_para(material);

                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndVertical();



        }

        }

        //mengban

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        if (material.GetFloat("_StencilStyle") == 0) { 

        _mengbanxx = Foldout2(_mengbanxx, "模板缓存(StencilBuffer)");

        if (_mengbanxx)
        {
            EditorGUI.indentLevel++;



            GUI_mengban(material);



            EditorGUI.indentLevel--;
        }
        }
        else { 
        _mengbanxx = Foldout(_mengbanxx, "模板缓存(StencilBuffer)");

        if (_mengbanxx)
        {
            EditorGUI.indentLevel++;



            GUI_mengban(material);



            EditorGUI.indentLevel--;
        }


        }







        EditorGUILayout.EndVertical();


        //综合选项下拉菜单
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        _Main_Foldout = Foldout(_Main_Foldout, "综合设置(ComprehensiveSettings)");

        if (_Main_Foldout)
        {
            EditorGUI.indentLevel++;

        //    EditorGUILayout.Space();

            GUI_Main(material);

            EditorGUI.indentLevel--;
        }

        EditorGUILayout.EndVertical();


        //说明

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        _Tip_Foldout = Foldout(_Tip_Foldout, "说明(Illustrate)");

            if (_Tip_Foldout)
            {
               EditorGUI.indentLevel++;


                GUI_Tip(material);

                EditorGUI.indentLevel--;
            }

        EditorGUILayout.EndVertical();


    }



    //基础设置内容显示

    void GUI_Base(Material material)

    {
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
       


            EditorGUILayout.BeginHorizontal();

       

        EditorGUILayout.PrefixLabel("混合模式");

     

            if (material.GetFloat("_Scr") == 1)
            {
                if (GUILayout.Button("Add", shortButtonStyle))
                {
                    material.SetFloat("_Scr", 5);
                    material.SetFloat("_Dst", 10);
                    material.SetFloat("_AlphaAdd", 0);
                }
            }
            else
            {
                if (GUILayout.Button("Alpha", shortButtonStyle))
                {
                    material.SetFloat("_Scr", 1);
                    material.SetFloat("_Dst", 1);
                    material.SetFloat("_AlphaAdd", 1);
                }
            }

            EditorGUILayout.EndHorizontal();


        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);


       
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            style.wordWrap = true;

            GUILayout.Label("*包含Alpha叠加和Add两种叠加模式", style);



            EditorGUILayout.EndVertical();
        }


        GUILayout.Space(5);









        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.PrefixLabel("剔除模式");


      

        if (material.GetFloat("_Cullmode") == 0)
        {
            if (GUILayout.Button("双面显示", shortButtonStyle))
            {
                material.SetFloat("_Cullmode", 1);
            }
        }
        else 
        {
            if (material.GetFloat("_Cullmode") == 1)
            {
                if (GUILayout.Button("显示背面", shortButtonStyle))
                {
                    material.SetFloat("_Cullmode", 2);
                }
            }

            else
            {
                if (GUILayout.Button("显示正面", shortButtonStyle))
                {
                    material.SetFloat("_Cullmode", 0);
                }
            }
        }

        EditorGUILayout.EndHorizontal();

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*包含显示正面，显示背面，双面显示三种模式", style);
            EditorGUILayout.EndVertical();
        }



        GUILayout.Space(5);


        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.PrefixLabel("显示在最前层");


        if (material.GetFloat("_Ztest") == 4)
        {
            if (GUILayout.Button("否", shortButtonStyle))
            {
                material.SetFloat("_Ztest", 8);
              
            }
        }
        else
        {
            if (GUILayout.Button("是", shortButtonStyle))
            {
                material.SetFloat("_Ztest", 4);
            }
        }

        EditorGUILayout.EndHorizontal();


        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*开启后深度测试ZTest设置为always，可以让特效显示在角色之前，避免穿模", style);
            EditorGUILayout.EndVertical();
        }

        GUILayout.Space(5);


        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.PrefixLabel("写入深度");


        if (material.GetFloat("_Zwrite") == 0)
        {
            if (GUILayout.Button("否", shortButtonStyle))
            {
                material.SetFloat("_Zwrite", 1);

            }
        }
        else
        {
            if (GUILayout.Button("是", shortButtonStyle))
            {
                material.SetFloat("_Zwrite", 0);
            }
        }

        EditorGUILayout.EndHorizontal();
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*开启后深度写入ZWrite改为on，开启后可以一定程度防止模型破面,但是透明区域后的其他特效层级显示会出现问题", style);
            EditorGUILayout.EndVertical();
        }








        EditorGUILayout.EndVertical();
        GUILayout.Space(5);




  











    }
    //主帖图具体显示内容

    public void GUI_Maintextures(Material material)
    {
//
       EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        m_MaterialEditor.ShaderProperty(ScreenAsMain, "屏幕图为主贴图");

       
       EditorGUILayout.EndVertical();

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*开启后使用GrabScreen作为主贴图，UV为GrabScreenPosition,使用UV扭曲来扭曲主贴图即可达到屏幕热扭曲效果", style);
            EditorGUILayout.EndVertical();
        }

    
     

        GUILayout.Space(5);
      
        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("主贴图"), mainTex_Sampler,TinColor, BackFaceColor);
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*主贴图用做主色纹理基底，后面跟着的两个颜色变量分别为正面主色和背面叠加色", style);
                EditorGUILayout.EndVertical();
            }

        if (mainTex_Sampler.textureValue != null) 
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _Mainxx = Foldouts(_Mainxx, "贴图设置(点击打开)");

                 if (_Mainxx)
                 {

                    EditorGUI.indentLevel++;
                
                  EditorGUILayout.BeginHorizontal();
                    m_MaterialEditor.ShaderProperty(MainTexC, "UVClamp");

                    m_MaterialEditor.ShaderProperty(MainTexCV, "");

                    EditorGUILayout.EndHorizontal();

                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                        EditorGUILayout.EndVertical();
                    }




                    m_MaterialEditor.ShaderProperty(MainTexAR, "使用R通道");

                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*勾选后Red通道成为透明通道，不勾选，Alpha通道为透明通道，没有透明通道的黑白图可以勾选此选项，有透明通道不要勾选", style);
                        EditorGUILayout.EndVertical();
                    }


                    m_MaterialEditor.ShaderProperty(MainTexrotat, "贴图旋转");
                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                        EditorGUILayout.EndVertical();
                    }


                    m_MaterialEditor.ShaderProperty(MainTexRefine, "Refine");
                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*贴图校色，可以拉大贴图明暗对比，制作更富色彩变化性的纹理，原理就是给原图一个power值，使其边缘更加锐利，在和原图lerp方式叠加起来，四个选项分别对应原图强度，修改图强度，修改图power值，原图修改图lerp混合程度（0-1之间即可）", style);
                        EditorGUILayout.EndVertical();
                    }
                         

                  EditorGUI.indentLevel--;
    
                }
               EditorGUILayout.EndVertical();

               if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*展开后可以对贴图属性做一些设置，包含uvclamp，透明通道，旋转，校色", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.TextureScaleOffsetProperty(mainTex_Sampler);
                EditorGUILayout.EndVertical();

                //
            GUILayout.Space(5);
                //

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.PrefixLabel("自定义偏移");
                if (material.GetFloat("_CustomdataMainTexUV") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_CustomdataMainTexUV", 1);

             

                }
            }
                else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_CustomdataMainTexUV", 0);


                }
            }

                EditorGUILayout.EndHorizontal();

                if (material.GetFloat("_CustomdataMainTexUV") == 1)
                {
                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);

          
                m_MaterialEditor.ShaderProperty(MainOffsetUC1, "U数据");
                m_MaterialEditor.ShaderProperty(MainOffsetUC2, "U通道");
           
                GUILayout.Space(5);

                    m_MaterialEditor.ShaderProperty(MainOffsetVC1, "V数据");
                    m_MaterialEditor.ShaderProperty(MainOffsetVC2, "V通道");

                    EditorGUILayout.EndVertical();


                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    EditorGUILayout.BeginHorizontal();

                    EditorGUILayout.PrefixLabel("影响多功能图");


                    if (material.GetFloat("_CAddTexUV") == 0)
                    {
                        if (GUILayout.Button("已关闭", shortButtonStyle))
                        {
                            material.SetFloat("_CAddTexUV", 1);



                        }
                    }
                    else
                    {
                        if (GUILayout.Button("已开启", shortButtonStyle))
                        {
                            material.SetFloat("_CAddTexUV", 0);


                        }
                    }





                    EditorGUILayout.EndHorizontal();


                    m_MaterialEditor.ShaderProperty(CAddTexUVT, "同速偏移");


                    EditorGUILayout.EndVertical();





                }

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*开启自定义数据控制贴图UVOffset，制作贴图一次性流动使用，开启自定义数据时请先custom1.xyzw,再添加custom2.xyzw，然后默认custom1.x控制U方向Offset，custom1.y控制V方向Offset，可自定义数据", style);
                    EditorGUILayout.EndVertical();
                }
   
                EditorGUILayout.EndVertical();

               //


                GUILayout.Space(5);

                //
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(MainTexUVS, "UV选择");
                if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*包含normal默认UV，polar极坐标UV，cylinder圆筒UV,UV2四种模式，默认UV即模型自带UV，极坐标即中心向四周扩散UV，圆筒UV即世界坐标下一个圆筒包裹的UV，主帖图设置圆筒UV可以制作角色身上能量流动，或者渐变效果，UV2即使第二套UV。", style);
                EditorGUILayout.EndVertical();
            }
                if (material.GetFloat("_MainTexUVS") == 1)
            {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(CenterU, "中心U");
                m_MaterialEditor.ShaderProperty(CenterV, "中心V");
                EditorGUILayout.EndVertical();

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*极坐标UV中心点位置", style);
                    EditorGUILayout.EndVertical();
                }

            }
                if (material.GetFloat("_MainTexUVS") == 2)
            {
                m_MaterialEditor.ShaderProperty(Face, "圆柱朝向");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*世界坐标系下圆柱UV的朝向", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.ShaderProperty(TexCenter, "圆柱中心");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*世界坐标系下圆柱UV的位置", style);
                    EditorGUILayout.EndVertical();
                }
            }
                EditorGUILayout.EndVertical();

                //

                GUILayout.Space(5);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(MainTexAC, "红蓝偏移");
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);


            //
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(MainUspeed, "U流动");
                m_MaterialEditor.ShaderProperty(MainVspeed, "V流动");
                EditorGUILayout.EndVertical();

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*主帖图的UV流动速度值", style);
                    EditorGUILayout.EndVertical();
                }

                //

                GUILayout.Space(5);

                //
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.PrefixLabel("多功能图");
                if (material.GetFloat("_IfAddTex") == 0)
                {
                    if (GUILayout.Button("已关闭", shortButtonStyle))
                    {
                        material.SetFloat("_IfAddTex", 1);


                    }
                }
                else
                {
                    if (GUILayout.Button("已开启", shortButtonStyle))
                    {
                        material.SetFloat("_IfAddTex", 0);


                    }
                }
                EditorGUILayout.EndHorizontal();
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*多功能图是在主贴图的基础上增加纹理细节，透明通道细节的额外贴图，可以叠加颜色，也可以充当遮罩等等", style);
                    EditorGUILayout.EndVertical();
                }
                EditorGUILayout.EndVertical();
                //


        }
        if (mainTex_Sampler.textureValue == null)
             {
                material.SetFloat("_IfAddTex", 0);
              }

             if (material.GetFloat("_IfAddTex") == 0) 
        
             {       
                material.SetFloat("_AddTexBlend", 0);
                material.SetFloat("_AddTexBlendMode", 0);
             }

       

    }




    //Mask贴图内容
    void GUI_Mask(Material material)

    {
      

      
        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("遮罩贴图"), Mask_Sampler);
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*遮罩贴图主要是针对透明通道做处理，剔除不想要的部分", style);
            EditorGUILayout.EndVertical();
        }


        if (Mask_Sampler.textureValue != null)

        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _Maskxx = Foldouts(_Maskxx, "贴图设置(点击打开)");

            if (_Maskxx)
            {
                EditorGUI.indentLevel++;

                //   EditorGUILayout.Space();
                EditorGUILayout.BeginHorizontal();
                m_MaterialEditor.ShaderProperty(MaskC, "UVClamp");
                m_MaterialEditor.ShaderProperty(MaskCV, "");
                EditorGUILayout.EndHorizontal();
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                    EditorGUILayout.EndVertical();
                }



                m_MaterialEditor.ShaderProperty(MaskAR, "使用R通道");


                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*勾选后Red通道成为透明通道，不勾选，Alpha通道为透明通道，没有透明通道的黑白图可以勾选此选项，有透明通道不要勾选", style);
                    EditorGUILayout.EndVertical();
                }





                m_MaterialEditor.ShaderProperty(Maskrotat, "贴图旋转");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.ShaderProperty(IfMaskColor, "贴图颜色");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*开启后将Mask的RGB值也乘到主题图上，可以用来做一些颜色叠加", style);
                    EditorGUILayout.EndVertical();
                }

                EditorGUI.indentLevel--;
            

        }
            EditorGUILayout.EndVertical();
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*展开后可以对贴图属性做一些设置，包含uvclamp，透明通道，旋转，启用遮罩颜色", style);
                EditorGUILayout.EndVertical();
            }
            m_MaterialEditor.TextureScaleOffsetProperty(Mask_Sampler);
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);




            EditorGUILayout.BeginVertical(EditorStyles.helpBox);


            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("自定义偏移");


            if (material.GetFloat("_CustomdataMaskUV") == 0)
            {




                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_CustomdataMaskUV", 1);

                  
                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_CustomdataMaskUV", 0);


                }
            }

            EditorGUILayout.EndHorizontal();




            if (material.GetFloat("_CustomdataMaskUV") == 1) { 


                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(MaskOffsetUC1, "U数据");
            m_MaterialEditor.ShaderProperty(MaskOffsetUC2, "U通道");

            GUILayout.Space(5);

            m_MaterialEditor.ShaderProperty(MaskOffsetVC1, "V数据");
            m_MaterialEditor.ShaderProperty(MaskOffsetVC2, "V通道");

            EditorGUILayout.EndVertical();

            }
            EditorGUILayout.EndVertical();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*开启自定义数据控制贴图UVOffset，制作贴图一次性流动使用，开启自定义数据时请先添加custom1.xyzw,再添加custom2.xyzw，默认custom1.z控制U方向Offset，custom1.w控制V方向Offset", style);
                EditorGUILayout.EndVertical();
            }






            //   GUILayout.Space(5);




            GUILayout.Space(5);




            m_MaterialEditor.FloatProperty(MaskScale, "遮罩强度");

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*遮罩在透明通道上相乘的倍数", style);
                EditorGUILayout.EndVertical();
            }
            GUILayout.Space(5);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            m_MaterialEditor.ShaderProperty(MaskTexUVS, "UV选择");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("**包含normal默认UV，polar极坐标UV，cylinder圆筒UV,UV2四种模式，默认UV即模型自带UV，极坐标即中心向四周扩散UV，圆筒UV即世界坐标下一个圆筒包裹的UV，主帖图设置圆筒UV可以制作角色身上能量流动，或者渐变效果，UV2即使第二套UV。", style);
                EditorGUILayout.EndVertical();
            }


            if (material.GetFloat("_MaskTexUVS") == 1)
            {

                m_MaterialEditor.ShaderProperty(CenterU, "中心U");
                m_MaterialEditor.ShaderProperty(CenterV, "中心V");


                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*极坐标UV中心点位置", style);
                    EditorGUILayout.EndVertical();
                }
            }



            if (material.GetFloat("_MaskTexUVS") == 2)
            {
               
                m_MaterialEditor.ShaderProperty(Face, "圆柱朝向");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*世界坐标系下圆柱UV的朝向", style);
                    EditorGUILayout.EndVertical();
                }
                m_MaterialEditor.ShaderProperty(TexCenter, "圆柱中心");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*世界坐标系下圆柱UV的位置", style);
                    EditorGUILayout.EndVertical();
                }
            }
            EditorGUILayout.EndVertical();

            GUILayout.Space(5);

      

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(MaskUspeed, "U流动");

     

            m_MaterialEditor.ShaderProperty(MaskVspeed, "V流动");

            EditorGUILayout.EndVertical();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*遮罩图的UV流动速度值", style);
                EditorGUILayout.EndVertical();
            }
            GUILayout.Space(5);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(IfMaskPlusTex, "开启额外遮罩图");

            if(material.GetFloat("_IfMaskPlusTex") == 1)
            {
            GUILayout.Space(5);

            m_MaterialEditor.TexturePropertySingleLine(new GUIContent("额外遮罩图"), MaskPlusTex);
                //

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _MaskPlusxx = Foldouts(_MaskPlusxx, "贴图设置(点击打开)");

                if (_MaskPlusxx)
                {
                    EditorGUI.indentLevel++;

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    EditorGUILayout.BeginHorizontal();
                    m_MaterialEditor.ShaderProperty(MaskPlusC, "UVClamp");
                    m_MaterialEditor.ShaderProperty(MaskPlusCV, "");
                    EditorGUILayout.EndHorizontal();

                    m_MaterialEditor.ShaderProperty(MaskPlusAR, "使用R通道");
                    m_MaterialEditor.ShaderProperty(MaskPlusR, "贴图旋转");

                    EditorGUILayout.EndVertical();
                    EditorGUI.indentLevel--;

                }
                    //
                    m_MaterialEditor.TextureScaleOffsetProperty(MaskPlusTex);
                EditorGUILayout.EndVertical();
                GUILayout.Space(5);

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(MaskPlusUspeed, "U流动");
                m_MaterialEditor.ShaderProperty(MaskPlusVspeed, "V流动");
                EditorGUILayout.EndVertical();
                GUILayout.Space(5);

            }

            EditorGUILayout.EndVertical();


        





        }
        GUILayout.Space(5);

        if (Mask_Sampler.textureValue == null)
        {
            material.SetFloat("_IfMaskPlusTex", 0);


        }



    }



    //溶解内容
    void GUI_Dissolve(Material material)

    {
       
        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("溶解贴图"), Dissolve_Tex, Dissolve_Color);

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*制作溶解镂空效果，溶解是非常棒得像素动画模式，无限中间帧，是丝滑特效的最大秘密，后面的颜色变量为溶解边缘颜色，值得注意的是将这个颜色透明度调为0后，溶解边缘颜色即为贴图固有色，做烟雾溶解时非常好用。", style);
            EditorGUILayout.EndVertical();
        }


        if (Dissolve_Tex.textureValue != null)
        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            _Dissolvexx = Foldouts(_Dissolvexx, "贴图设置(点击打开)");

            if (_Dissolvexx)
            {
                EditorGUI.indentLevel++;
                EditorGUILayout.BeginHorizontal();
                m_MaterialEditor.ShaderProperty(DissolveC, "UVClamp");
                m_MaterialEditor.ShaderProperty(DissolveCV, "");
                EditorGUILayout.EndHorizontal();
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                    EditorGUILayout.EndVertical();
                }
                m_MaterialEditor.ShaderProperty(DissolveAR, "使用R通道");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*勾选后Red通道成为溶解通道，不勾选，Alpha通道为溶解通道，没有透明通道的黑白图可以勾选此选项，有透明通道不要勾选", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.ShaderProperty(Dissolve_Rotation, "贴图旋转");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                    EditorGUILayout.EndVertical();
                }
                m_MaterialEditor.ShaderProperty(DissolveTexExp, "PowerExp");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图数据做power运算，使其棱角更加分明，溶解时边缘会更加锋利，power在0-1时相反，可以让溶解更加柔和", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.ShaderProperty(IfDissolveColor, "溶解颜色受顶点色影响");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*边缘颜色是否受粒子系统的颜色影响", style);
                    EditorGUILayout.EndVertical();
                }

                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndVertical();


            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*展开后可以对贴图属性做一些设置，包含uvclamp，通道选择，旋转，贴图数据power处理", style);
                EditorGUILayout.EndVertical();
            }
            m_MaterialEditor.TextureScaleOffsetProperty(Dissolve_Tex);
            EditorGUILayout.EndVertical();

            GUILayout.Space(5);



            //




            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("附加溶解图");


            if (material.GetFloat("_IfDissolvePlus") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_IfDissolvePlus", 1);
                    material.SetFloat("_DissolveTexDivide", 1);


                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_IfDissolvePlus", 0);


                }
            }

            EditorGUILayout.EndHorizontal();
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*开始附加溶解图后，可以制作方向溶解了。比如从左到右，从上到下，从中心到四周等等效果", style);
                EditorGUILayout.EndVertical();
            }

         //   GUILayout.Space(5);


            if (material.GetFloat("_IfDissolvePlus") == 1)
            {
               
                m_MaterialEditor.TexturePropertySingleLine(new GUIContent("附加溶解贴图"), DissloveTexPlus);
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*附加溶解图可以使用一张渐变图，比如从左到右的黑白渐变，这样溶解时就会有从左到右的溶解趋势，同理还可以使用其他方向或者一个扩散状的黑白渐变来增加溶解方向趋势感", style);
                    EditorGUILayout.EndVertical();
                }

                if (DissloveTexPlus.textureValue != null)
                {
                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                    _Dissolveplusxx = Foldouts(_Dissolveplusxx, "贴图设置(点击打开)");

                    if (_Dissolveplusxx)
                    {
                        EditorGUI.indentLevel++;
                        EditorGUILayout.BeginHorizontal();
                        m_MaterialEditor.ShaderProperty(DissolvePlusC, "UVClamp");
                        m_MaterialEditor.ShaderProperty(DissolvePlusCV, "");
                        EditorGUILayout.EndHorizontal();
                        if (_tips == true)
                        {

                            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                            style.fontSize = 10;
                            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                            GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                            EditorGUILayout.EndVertical();
                        }
                        m_MaterialEditor.ShaderProperty(DissolvePlusAR, "使用R通道");
                        if (_tips == true)
                        {

                            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                            style.fontSize = 10;
                            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                            GUILayout.Label("*勾选后Red通道成为溶解通道，不勾选，Alpha通道为溶解通道，没有透明通道的黑白图可以勾选此选项，有透明通道不要勾选", style);
                            EditorGUILayout.EndVertical();
                        }


                        m_MaterialEditor.ShaderProperty(DissolvePlusR, "贴图旋转");


                        if (_tips == true)
                        {

                            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                            style.fontSize = 10;
                            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                            GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                            EditorGUILayout.EndVertical();
                        }

                     


                        EditorGUI.indentLevel--;
                    }

                    EditorGUILayout.EndVertical();

                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*展开后可以对贴图属性做一些设置，包含uvclamp，通道选择，旋转", style);
                        EditorGUILayout.EndVertical();
                    }
                    m_MaterialEditor.TextureScaleOffsetProperty(DissloveTexPlus);


                 






                    EditorGUILayout.EndVertical();


                }
                else
                {
                    material.SetFloat("_DissolveTexDivide",1);
                }
                

                m_MaterialEditor.ShaderProperty(DissolveTexDivide, "溶解主贴图衰减");

                GUILayout.Space(5);
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*溶解图衰减后，附加溶解图的溶解趋势会变强，溶解的方向感会更强", style);
                    EditorGUILayout.EndVertical();
                }


            

            }



            EditorGUILayout.EndVertical();




            GUILayout.Space(5);


            //

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("自定义偏移");


            if (material.GetFloat("_IfDissolveOffsetC") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_IfDissolveOffsetC", 1);




                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_IfDissolveOffsetC", 0);



                }


            }



            EditorGUILayout.EndHorizontal();


            if (material.GetFloat("_IfDissolveOffsetC") == 1) {


                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(DissolveOffsetUC1, "U数据");
                m_MaterialEditor.ShaderProperty(DissolveOffsetUC2, "U通道");

                GUILayout.Space(5);

                m_MaterialEditor.ShaderProperty(DissolveOffsetVC1, "V数据");
                m_MaterialEditor.ShaderProperty(DissolveOffsetVC2, "V通道");

                EditorGUILayout.EndVertical();

            }



                if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*开启自定义数据控制溶解偏移，开启自定义数据时请先添加custom1.xyzw,再添加custom2.xyzw，默认custom2.x和custom2.y控制溶解偏移程度", style);
                EditorGUILayout.EndVertical();
            }








            EditorGUILayout.EndVertical();
            GUILayout.Space(5);


            //

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        //   
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("自定义溶解系数");


            if (material.GetFloat("_CustomdataDis") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_CustomdataDis", 1);



   








                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_CustomdataDis", 0);




               


                }
       

            }



            EditorGUILayout.EndHorizontal();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*开启自定义数据控制溶解程度，开启自定义数据时请先添加custom1.xyzw,再添加custom2.xyzw，默认custom2.z控制溶解程度，可以通过下面的两个选项自定义通道，开启自定义数据后，溶解系数将会失效，并隐藏", style);
                EditorGUILayout.EndVertical();
            }

        //    GUILayout.Space(5);


            if (material.GetFloat("_CustomdataDis") == 1) {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(DissolveFactorC1, "数据");


            m_MaterialEditor.ShaderProperty(DissolveFactorC2, "通道");
                EditorGUILayout.EndVertical();
                GUILayout.Space(5);


                if (material.GetFloat("_CustomdataDis") == 1)
                {

                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.PrefixLabel("拖尾模式");
                    if (material.GetFloat("_CustomdataDisT") == 0)
                    {
                        if (GUILayout.Button("已关闭", shortButtonStyle))
                        {
                            material.SetFloat("_CustomdataDisT", 1);
                        }
                    }
                    else
                    {
                        if (GUILayout.Button("已开启", shortButtonStyle))
                        {
                            material.SetFloat("_CustomdataDisT", 0);
                        }
                    }
                    EditorGUILayout.EndHorizontal();
                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*自定义数据对粒子拖尾并不生效，这里我们开启拖尾溶解模式后，将不再使用自定义数据，而是改用粒子系统的ColoroverLifetime的Alpha通道来控制溶解程度", style);
                        EditorGUILayout.EndVertical();
                    }

                    GUILayout.Space(5);

                }
                //    
            }

            EditorGUILayout.EndVertical();


           


            if (material.GetFloat("_CustomdataDis") == 0) 
            
            {
                material.SetFloat("_CustomdataDisT",0);
            }









            GUILayout.Space(5);


            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("溶解模式");


            if (material.GetFloat("_soft_sting") == 0)
            {


                if (GUILayout.Button("软边溶解模式", shortButtonStyle))
                {
                    material.SetFloat("_soft_sting", 1);

                    material.SetFloat("_sot_sting_A", 1);


                }
            }
            else
            {


                if (GUILayout.Button("硬边溶解模式", shortButtonStyle))
                {
                    material.SetFloat("_soft_sting", 0);

                    material.SetFloat("_sot_sting_A", 0);


                }
            }
           
            EditorGUILayout.EndHorizontal();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*溶解模式有软边溶解和硬边溶解两种模式软边溶解时边缘有透明度渐变过渡比较柔和，硬边溶解则是cutout的样式", style);
                EditorGUILayout.EndVertical();
            }
            GUILayout.Space(5);


            if (material.GetFloat("_CustomdataDis") == 0)
            {


                m_MaterialEditor.ShaderProperty(Dissolve_Factor, "溶解系数");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*溶解程度，0为刚好不溶解，1为恰好完全溶解，溶解系数在开启自定义数据后将失效并隐藏，将由自定义数据完全控制溶解", style);
                    EditorGUILayout.EndVertical();
                }

                GUILayout.Space(5);
            }






            if (material.GetFloat("_soft_sting") == 0)
            { 

                m_MaterialEditor.ShaderProperty(Dissolve_Soft, "软硬程度");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*软溶解模式溶解边缘的软硬程度，数值越高溶解边缘越锐利，越接近硬溶解模式，相反则溶解的越加柔和", style);
                    EditorGUILayout.EndVertical();
                }






                GUILayout.Space(5);
            }
            if (material.GetFloat("_soft_sting") == 1)
            { 

                m_MaterialEditor.ShaderProperty(Dissolve_Wide, "溶解宽度");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*溶解边缘的宽度，对软硬溶解都生效", style);
                    EditorGUILayout.EndVertical();
                }


                GUILayout.Space(5);
            }


            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            m_MaterialEditor.ShaderProperty(DissolveTexUVS2, "UV选择");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("**包含normal默认UV，polar极坐标UV，cylinder圆筒UV,UV2四种模式，默认UV即模型自带UV，极坐标即中心向四周扩散UV，圆筒UV即世界坐标下一个圆筒包裹的UV，主帖图设置圆筒UV可以制作角色身上能量流动，或者渐变效果，UV2即使第二套UV。", style);
                EditorGUILayout.EndVertical();
            }


            if (material.GetFloat("_DissolveTexUVS2") == 1)
            {

                m_MaterialEditor.ShaderProperty(CenterU, "中心U");
                m_MaterialEditor.ShaderProperty(CenterV, "中心V");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*极坐标UV的中心点位置", style);
                    EditorGUILayout.EndVertical();
                }
            }


            if (material.GetFloat("_DissolveTexUVS2") == 2)
            {
               
                m_MaterialEditor.ShaderProperty(Face, "圆柱朝向");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*世界坐标下圆柱的朝向", style);
                    EditorGUILayout.EndVertical();
                }
                m_MaterialEditor.ShaderProperty(TexCenter, "圆柱中心");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*世界坐标下圆柱的位置", style);
                    EditorGUILayout.EndVertical();
                }
            }
            EditorGUILayout.EndVertical();

            GUILayout.Space(5);








            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(Dissolve_Uspeed, "U流动");

    

            m_MaterialEditor.ShaderProperty(Dissolve_Vspeed, "V流动");

            EditorGUILayout.EndVertical();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*溶解图的UV滚动速度", style);
                EditorGUILayout.EndVertical();
            }

        

        }

        GUILayout.Space(5);



        if (Dissolve_Tex.textureValue == null)
        {

            material.SetFloat("_IfDissolvePlus", 0);

            material.SetFloat("_DissolveTexDivide", 1);
        }


    }


    //UV扭曲内容
    void GUI_Distort(Material material)

    {
     

        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("UV扭曲贴图"), Distort_Tex);

       
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*扭曲贴图uv信息，可以根据需求选择需要扭曲的贴图，扭曲uv后贴图出现液化效果，很适合制作水波纹，写实类能量涌动效果", style);
            EditorGUILayout.EndVertical();
        }







        if (Distort_Tex.textureValue != null)
        {

            //
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _DistortTexxx = Foldouts(_DistortTexxx, "贴图设置(点击打开)");


            if (_DistortTexxx)
            {
                EditorGUI.indentLevel++;


               



                if (material.GetFloat("_IfFlowmap") == 0) {

                    m_MaterialEditor.ShaderProperty(DistortTexAR, "使用R通道");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*开启后R通道将做为扭曲通道，不开启使用Alpha通道为扭曲通道，黑白图没有Alpha通道请勾选此选项，有Alpha通道的贴图请不要勾选", style);
                    EditorGUILayout.EndVertical();
                }

                if(material.GetFloat("_IfNormalDistort") == 0) {
                    m_MaterialEditor.ShaderProperty(DistortRemap, "Remap");
                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*把uv扭曲的数据从0到1映射到-0.5到0.5，使扭曲方向更加丰富", style);
                        EditorGUILayout.EndVertical();
                    }


                    }


                    m_MaterialEditor.ShaderProperty(IfNormalDistort, "法线化");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*开启后，将对扭曲贴图进行法线化处理，再对其他需要扭曲的纹理层进行扭曲，开启后扭曲的趋势将会是向四周扩散移动，不开启扭曲的趋势是向右上角移动，适合用来做屏幕扭曲的效果", style);
                    EditorGUILayout.EndVertical();
                }


                }


                m_MaterialEditor.ShaderProperty(IfFlowmap, "使用FlowMap图");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*开启后使用FLowMap算法来做为扭曲贴图，可以用来制作烟尘消散效果", style);
                    EditorGUILayout.EndVertical();
                }

                EditorGUI.indentLevel--;

            }

            EditorGUILayout.EndVertical();










            m_MaterialEditor.TextureScaleOffsetProperty(Distort_Tex);
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);





            //

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            m_MaterialEditor.TexturePropertySingleLine(new GUIContent("UV扭曲遮罩贴图"), DistortMaskTex);


            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*uv扭曲遮罩图", style);
                EditorGUILayout.EndVertical();
            }







            if (DistortMaskTex.textureValue != null)
            {


                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                _DistortMaskTexxx = Foldouts(_DistortMaskTexxx, "贴图设置(点击打开)");


                if (_DistortMaskTexxx)
                {
                    EditorGUI.indentLevel++;

                    EditorGUILayout.BeginHorizontal();
                    m_MaterialEditor.ShaderProperty(DistortMaskTexC, "UVClamp");

                    m_MaterialEditor.ShaderProperty(DistortMaskTexCV, "");

                    EditorGUILayout.EndHorizontal();

                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                        EditorGUILayout.EndVertical();
                    }


                    m_MaterialEditor.ShaderProperty(DistortMaskTexAR, "使用R通道");
                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*开启后R通道将做为扭曲遮罩通道，不开启使用Alpha通道为扭曲遮罩通道，黑白图没有Alpha通道请勾选此选项，有Alpha通道的贴图请不要勾选", style);
                        EditorGUILayout.EndVertical();
                    }



                    m_MaterialEditor.ShaderProperty(DistortMaskTexR, "贴图旋转");
                    if (_tips == true)
                    {

                        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                        style.fontSize = 10;
                        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                        GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                        EditorGUILayout.EndVertical();
                    }




                  






                    EditorGUI.indentLevel--;

                }

                EditorGUILayout.EndVertical();










                m_MaterialEditor.TextureScaleOffsetProperty(DistortMaskTex);
                EditorGUILayout.EndVertical();
                GUILayout.Space(5);


            }
            EditorGUILayout.EndVertical();

            //



            GUILayout.Space(5);



            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("自定义强度");


            if (material.GetFloat("_CustomDistort") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_CustomDistort", 1);

    

                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_CustomDistort", 0);


                }
            }

          







                EditorGUILayout.EndHorizontal();



            if (material.GetFloat("_CustomDistort") == 1)
            {


                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(DistortFactorC1, "数据");


                m_MaterialEditor.ShaderProperty(DistortFactorC2, "通道");
                EditorGUILayout.EndVertical();


            }
            EditorGUILayout.EndVertical();
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*开启自定义数据控制贴图扭曲程度，配合溶解可以用来制作flowmap溶解效果，开启自定义数据时请先custom1.xyzw,再添加custom2.xyzw，然后custom2.w控制扭曲程度，开启自定义数据后，扭曲程度将会失效，并隐藏", style);
                EditorGUILayout.EndVertical();
            }

            GUILayout.Space(5);

            if (material.GetFloat("_CustomDistort") == 0)
            { 

                m_MaterialEditor.ShaderProperty(Distort_Factor, "UV扭曲程度");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*扭曲程度，开启自定义数据后，扭曲程度将会失效，并隐藏", style);
                    EditorGUILayout.EndVertical();
                }

                GUILayout.Space(5);


            }
      

        

              EditorGUILayout.BeginVertical(EditorStyles.helpBox);
              GUILayout.Label("    UV与主帖图一致");
              EditorGUILayout.EndVertical();



      

          
      

            GUILayout.Space(5);





            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(Distort_Uspeed, "U流动");



            m_MaterialEditor.ShaderProperty(Distort_Vspeed, "V流动");


            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*扭曲贴图的UV流动速度", style);
                EditorGUILayout.EndVertical();
            }

            EditorGUILayout.EndVertical();

            GUILayout.Space(5);

           

            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("扭动主帖图");


            if (material.GetFloat("_DistortMainTex") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_DistortMainTex", 1);


                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_DistortMainTex", 0);


                }
            }

            EditorGUILayout.EndHorizontal();







           if (material.GetFloat("_IfAddTex") == 1)
            {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("扭动附加图");


                if (material.GetFloat("_DistortAddTex") == 0)
                {
                    if (GUILayout.Button("已关闭", shortButtonStyle))
                    {
                        material.SetFloat("_DistortAddTex", 1);


                    }
                }
                else
                {
                    if (GUILayout.Button("已开启", shortButtonStyle))
                    {
                        material.SetFloat("_DistortAddTex", 0);


                    }
                }

                EditorGUILayout.EndHorizontal();


            }






            if (Mask_Sampler.textureValue != null)

            { 
                EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("扭动遮罩图");


            if (material.GetFloat("_DistortMask") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_DistortMask", 1);


                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_DistortMask", 0);


                }
            }

            EditorGUILayout.EndHorizontal();

         //   GUILayout.Space(5);

            }




            if (Dissolve_Tex.textureValue != null)
            {
                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.PrefixLabel("扭动溶解帖图");


                if (material.GetFloat("_DistortDisTex") == 0)
                {
                    if (GUILayout.Button("已关闭", shortButtonStyle))
                    {
                        material.SetFloat("_DistortDisTex", 1);


                    }
                }
                else
                {
                    if (GUILayout.Button("已开启", shortButtonStyle))
                    {
                        material.SetFloat("_DistortDisTex", 0);


                    }
                }

                EditorGUILayout.EndHorizontal();

         

            }



            if (NormalTex.textureValue != null && material.GetFloat("_IfCustomLight") == 1)

            {
                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.PrefixLabel("扭动法线图");


                if (material.GetFloat("_DistortNormalTex") == 0)
                {
                    if (GUILayout.Button("已关闭", shortButtonStyle))
                    {
                        material.SetFloat("_DistortNormalTex", 1);


                    }
                }
                else
                {
                    if (GUILayout.Button("已开启", shortButtonStyle))
                    {
                        material.SetFloat("_DistortNormalTex", 0);


                    }
                }

                EditorGUILayout.EndHorizontal();

            //    GUILayout.Space(5);

            }


         
        }

        if (Distort_Tex.textureValue == null)
        {
            material.SetFloat("_DistortFactor", 0);

                DistortMaskTex.textureValue = null;


        }
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*分别开启或关闭扭曲各个图层的UV信息", style);
            EditorGUILayout.EndVertical();
        }

        GUILayout.Space(5);
    }


    //FNL内容
    void GUI_FNL(Material material)

    {

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);




        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.PrefixLabel("反向菲尼尔");


                 if (material.GetFloat("_FNLfanxiangkaiguan") == 0)
                {
                  if (GUILayout.Button("已关闭", shortButtonStyle))
                   { 
                     material.SetFloat("_FNLfanxiangkaiguan", 1);


                   }

                 }
                 else
                 {
                       if (GUILayout.Button("已开启", shortButtonStyle))
                       { 
                     material.SetFloat("_FNLfanxiangkaiguan", 0);

                       }

                  }

        EditorGUILayout.EndHorizontal();
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*反向菲尼尔后可以软化模型边缘，减少特效的模型感", style);
            EditorGUILayout.EndVertical();
        }

        if (material.GetFloat("_FNLfanxiangkaiguan") == 1) 
        {

            GUILayout.Space(5);
            m_MaterialEditor.ShaderProperty(Fnl_Soft, "模型软化程度");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*软化程度越高，模型边缘剔除越多，模型感越弱", style);
                EditorGUILayout.EndVertical();
            }


            GUILayout.Space(5);


            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("软化剔除背面");


            if (material.GetFloat("_softback") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_softback", 1);


                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_softback", 0);


                }
            }

            EditorGUILayout.EndHorizontal();
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*反向菲尼尔直接剔除掉背面，在开启菲尼尔颜色时，模型边缘容易破面，此选项可以一定程度减少破面，一般不用开启", style);
                EditorGUILayout.EndVertical();
            }


            GUILayout.Space(5);











        }



        if (material.GetFloat("_FNLfanxiangkaiguan") == 0)
        {
            material.SetFloat("_softFacotr", 0);
        }



        //  }



        EditorGUILayout.EndVertical();




        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        m_MaterialEditor.ShaderProperty(IfFNLAlpha, "影响透明通道");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*开启后菲尼尔的数值会乘在透明通道上", style);
            EditorGUILayout.EndVertical();
        }
        GUILayout.Space(5);
        m_MaterialEditor.ShaderProperty(Fnl_Color, "菲尼尔颜色");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*菲尼尔的叠加颜色", style);
            EditorGUILayout.EndVertical();
        }

        GUILayout.Space(5);


            m_MaterialEditor.ShaderProperty(Fnl_Scale, "菲尼尔强度");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*菲尼尔的强度，颜色里也可以调强度，这里增加这个参数是为了方便k帧", style);
            EditorGUILayout.EndVertical();
        }

        GUILayout.Space(5);



     


            m_MaterialEditor.ShaderProperty(Fnl_Power, "菲尼尔锐化");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*菲尼尔的PowerExp值，使菲尼尔效果更加锐利", style);
            EditorGUILayout.EndVertical();
        }
        GUILayout.Space(5);

            m_MaterialEditor.ShaderProperty(Dir, "菲尼尔偏移");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*菲尼尔的视角偏移，调整此值可以调整类似光源方向的感觉", style);
            EditorGUILayout.EndVertical();
        }


        
      



        EditorGUILayout.EndVertical();


        EditorGUILayout.EndVertical();


        GUILayout.Space(5);














    }

    //VTO内容
    void GUI_VTO(Material material)

    {


        if (material.GetFloat("_IfVAT") == 0) { 




        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("顶点偏移贴图"), Vto_Tex);

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*用来制作顶点动画，这里我们这里只能根据法线方向进行顶点移动，如果需要改变移动方向，可以去修改模型的法线朝向", style);
            EditorGUILayout.EndVertical();
        }




        if (Vto_Tex.textureValue != null)

        {


            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _VTOxx = Foldouts(_VTOxx, "贴图设置(点击打开)");

            if (_VTOxx)
        {
            EditorGUI.indentLevel++;
                EditorGUILayout.BeginHorizontal();
                m_MaterialEditor.ShaderProperty(VTOC, "UVClamp");
    
                m_MaterialEditor.ShaderProperty(VTOCV, "");

                EditorGUILayout.EndHorizontal();

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                    EditorGUILayout.EndVertical();
                }
                m_MaterialEditor.ShaderProperty(VTOAR, "使用R通道");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*勾选后Red通道成为偏移通道，不勾选，Alpha通道为偏移通道，没有透明通道的黑白图可以勾选此选项，有透明通道不要勾选", style);
                    EditorGUILayout.EndVertical();
                }
                m_MaterialEditor.ShaderProperty(VTOR, "贴图旋转");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                    EditorGUILayout.EndVertical();
                }
                m_MaterialEditor.ShaderProperty(VTOTexExp, "PowerExp");


                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图数据做power处理，可以让渐变更加陡峭，顶点偏移的变化程度也会更加剧烈，坡度更加陡峭", style);
                    EditorGUILayout.EndVertical();
                }
            


                m_MaterialEditor.ShaderProperty(VTORemap, "Remap");


                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*把贴图数据从0to1转换到0.5to-0.5", style);
                    EditorGUILayout.EndVertical();
                }
                EditorGUI.indentLevel--;




            }
            EditorGUILayout.EndVertical();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*展开后可以对贴图属性做一些设置，包含uvclamp，通道选择，旋转，贴图数据power处理", style);
                EditorGUILayout.EndVertical();
            }

            m_MaterialEditor.TextureScaleOffsetProperty(Vto_Tex);
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);
        }









     
        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("顶点遮罩贴图"), Vto_Mask);

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*用来制作顶点动画的遮罩，防止破面，比如球形的上下两个位置非常容易破面，这里我们只需要添加一个上下有一个渐变小黑条的遮罩图，就能让圆球上下两个位置不进行顶点偏移，从而防止破面", style);
            EditorGUILayout.EndVertical();
        }
        if (Vto_Mask.textureValue != null)

        {


            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _VTOMaskxx = Foldouts(_VTOMaskxx, "贴图设置(点击打开)");

            if (_VTOMaskxx)
            {
                EditorGUI.indentLevel++;
                EditorGUILayout.BeginHorizontal();

                m_MaterialEditor.ShaderProperty(VTOMaskC, "UVClamp");

                m_MaterialEditor.ShaderProperty(VTOMaskCV, "");

                EditorGUILayout.EndHorizontal();
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                    EditorGUILayout.EndVertical();
                }


                m_MaterialEditor.ShaderProperty(VTOMaskAR, "使用R通道");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*勾选后Red通道成为偏移遮罩通道，不勾选，Alpha通道为偏移遮罩通道，没有透明通道的黑白图可以勾选此选项，有透明通道不要勾选", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.ShaderProperty(VTOMaskR, "贴图旋转");


                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                    EditorGUILayout.EndVertical();
                }


                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndVertical();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*展开后可以对贴图属性做一些设置，包含uvclamp，通道选择，旋转", style);
                EditorGUILayout.EndVertical();
            }
            m_MaterialEditor.TextureScaleOffsetProperty(Vto_Mask);
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);
        }






      // 

        if (Vto_Tex.textureValue != null)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("自定义强度");


            if (material.GetFloat("_ToggleSwitch0") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_ToggleSwitch0", 1);



                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_ToggleSwitch0", 0);



                }
            }


        




                EditorGUILayout.EndHorizontal();



            if (material.GetFloat("_ToggleSwitch0") == 1)
            {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(VTOFactorC1, "数据");


                m_MaterialEditor.ShaderProperty(VTOFactorC2, "通道");
                EditorGUILayout.EndVertical();

            }



            EditorGUILayout.EndVertical();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*开启自定义数据控制模型膨胀程度，可以制作爆炸之类的效果，开启自定义数据时请先添加custom1.xyzw,再添加custom2.xyzw，默认custom2.w控制膨胀程度，开启自定义数据后，膨胀程度将会失效，并隐藏", style);
                EditorGUILayout.EndVertical();
            }

            GUILayout.Space(5);

            if (material.GetFloat("_ToggleSwitch0") == 0)
            {
                m_MaterialEditor.ShaderProperty(Vto_Scale, "顶点偏移程度");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*膨胀程度，开启自定义数据后，膨胀程度将会失效，并隐藏", style);
                    EditorGUILayout.EndVertical();
                }

                GUILayout.Space(5);
            }






      

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            GUILayout.Label("    UV与主帖图一致");
            EditorGUILayout.EndVertical();







            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(Vto_Uspeed, "U流动");
     
            m_MaterialEditor.ShaderProperty(Vto_Vspeed, "V流动");

            EditorGUILayout.EndVertical();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*顶点偏移图的UV流动速度", style);
                EditorGUILayout.EndVertical();
            }

        }

        if (Vto_Tex.textureValue == null)
        {
            material.SetFloat("_VTOFactor", 0);
        }

        GUILayout.Space(5);
        }

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        m_MaterialEditor.ShaderProperty(IfVAT, "开启VAT");
        if (material.GetFloat("_IfVAT") == 1) { 
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("VAT位置图"), VATPositionTex);

        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("VAT法线图"), VATNormalTex);


        EditorGUILayout.EndVertical();

            GUILayout.Space(5);

            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("开启粒子系统模式");


            if (material.GetFloat("_ParticleVAT") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_ParticleVAT", 1);



                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_ParticleVAT", 0);



                }
            }
            EditorGUILayout.EndHorizontal();






            GUILayout.Space(5);



            EditorGUILayout.BeginVertical(EditorStyles.helpBox);



            if (material.GetFloat("_ParticleVAT") == 1) { 

                EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("自定义进度");


            if (material.GetFloat("_CustomVAT") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_CustomVAT", 1);



                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_CustomVAT", 0);



                }
            }
            EditorGUILayout.EndHorizontal();

            if (material.GetFloat("_CustomVAT") == 1)
            {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(VATFrameC1, "数据");


               m_MaterialEditor.ShaderProperty(VATFrameC2, "通道");
                EditorGUILayout.EndVertical();

            }

            }

            if (material.GetFloat("_CustomVAT") == 0)
                {
                    m_MaterialEditor.ShaderProperty(VATFrameFactor, "动画进度");


                }

                EditorGUILayout.EndVertical();

            if (material.GetFloat("_ParticleVAT") == 0) {
                material.SetFloat("_CustomVAT",0);
            }




            //     EditorGUILayout.BeginVertical(EditorStyles.helpBox);


                //    m_MaterialEditor.ShaderProperty(VATRotate, "旋转角度");
                //     m_MaterialEditor.ShaderProperty(VATPivot, "轴心位置");

                //   EditorGUILayout.EndVertical();




        }
     


        EditorGUILayout.EndVertical();


    }



    //综合设置内容显示

    void GUI_Main(Material material)

    {

    
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(MainAlpha, "总透明度");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*整体最后结果的透明度倍增，最大值不会超过1", style);
            EditorGUILayout.EndVertical();
        }

        GUILayout.Space(5);


     //       m_MaterialEditor.ShaderProperty(MainAlphaPower, "总透明度锐化");

        
    //        GUILayout.Space(5);

            m_MaterialEditor.ShaderProperty(Qubaohedu, "去饱和度");
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*去饱和程度0为不去除，1为完全黑白", style);
            EditorGUILayout.EndVertical();
        }

        EditorGUILayout.EndVertical();
            GUILayout.Space(5);


        //

      






        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.PrefixLabel("软粒子");
       


            if (material.GetFloat("_Depthfadeon") == 0)
        {
            if (GUILayout.Button("已关闭", shortButtonStyle))
            {
                material.SetFloat("_Depthfadeon", 1);


            }
        }
        else
        {
            if (GUILayout.Button("已开启", shortButtonStyle))
            {
                material.SetFloat("_Depthfadeon", 0);


            }
        }

        EditorGUILayout.EndHorizontal();
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*特效与地面人物穿插时，会软化掉穿插部分，使相交处没用明显痕迹，场景必须开启深度图此选项才能生效，如果相机是正交相机，此功能将失效，因为正交相机没有相机深度！", style);
            EditorGUILayout.EndVertical();
        }






        if (material.GetFloat("_Depthfadeon") == 1)
        {

            GUILayout.Space(5);

            m_MaterialEditor.ShaderProperty(DepthFade, "软粒子羽化程度");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*羽化程度，数值越高软化范围越大，需要根据模型比例尺调整，如果开启反向软粒子后，此选项变为强化交界处的宽度值", style);
                EditorGUILayout.EndVertical();
            }


            GUILayout.Space(5);


            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.PrefixLabel("反向软粒子");



            if (material.GetFloat("_DepthF") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_DepthF", 1);


                }
            }
            else
            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_DepthF", 0);


                }
            }

            EditorGUILayout.EndHorizontal();

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*开启后特效与模型穿插部分将会加强，可以用来制作球形防护罩和场景穿插时相交部分的显示，会使防护罩立体感更强", style);
                EditorGUILayout.EndVertical();
            }






            if (material.GetFloat("_DepthF") == 1)
            {
                GUILayout.Space(5);

                m_MaterialEditor.ShaderProperty(DepthColor, "边缘颜色");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*交叉线的叠加颜色", style);
                    EditorGUILayout.EndVertical();
                }

            }








        }
        else {

            material.SetFloat("_DepthF", 0);
        }
        EditorGUILayout.EndVertical();





        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("开启自定义光照");
        if (material.GetFloat("_IfCustomLight") == 0)
        {
            if (GUILayout.Button("已关闭", shortButtonStyle))
            {
                material.SetFloat("_IfCustomLight", 1);


            }
        }
        else
        {
            if (GUILayout.Button("已开启", shortButtonStyle))
            {
                material.SetFloat("_IfCustomLight", 0);


            }
        }

        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndVertical();
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*开启自定义光照后，材质可以接受场景里的灯光，并且附带了法线内容，可以用来制作写实风格的特效，开启后在综合设置上方出现自定义光照页签", style);
            EditorGUILayout.EndVertical();
        }


        if (material.GetFloat("_IfCustomLight") == 0)
        {
            material.SetFloat("_LightScale", 0);
        }



        //

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.PrefixLabel("视差映射");



        if (material.GetFloat("_IfPara") == 0)
        {
            if (GUILayout.Button("已关闭", shortButtonStyle))
            {
                material.SetFloat("_IfPara", 1);


            }
        }
        else
        {
            if (GUILayout.Button("已开启", shortButtonStyle))
            {
                material.SetFloat("_IfPara", 0);


            }
        }

        EditorGUILayout.EndHorizontal();


        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*开启视差映射后，材质表面会有下凹的表现，非常适合用来制作地裂效果，特别注意如果使用的是粒子系统，不要使用公告板模式，要使用mesh，加一个plane片即可，否则旋转时会有bug", style);
            EditorGUILayout.EndVertical();
        }





        EditorGUILayout.EndVertical();











        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("开启初学者模式");
        if (_tips == false)
        {
            if (GUILayout.Button("已关闭", shortButtonStyle))
            {
                _tips = true;

            }
        }
        else

        {
            if (GUILayout.Button("已开启", shortButtonStyle))
            {
                _tips = false;

            }
        }

        EditorGUILayout.EndHorizontal();

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*开启后会显示每一个变量的详细功能信息，适合新使用材质的初学者", style);
            EditorGUILayout.EndVertical();
        }
        EditorGUILayout.EndVertical();









        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUI.BeginChangeCheck();
        {
            MaterialProperty[] props = { };
            base.OnGUI(m_MaterialEditor, props);
        }
        EditorGUILayout.EndVertical();
        GUILayout.Space(5);
    }

    void GUI_Add(Material material)

    {




        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("多功能图"), AddTex_Sampler, AddTexColor);


        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*附加图用来增加主帖图纹理细节", style);
            EditorGUILayout.EndVertical();
        }

        if (AddTex_Sampler.textureValue != null)

        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _AddTexxx = Foldouts(_AddTexxx, "贴图设置(点击打开)");

            if (_AddTexxx)
            {
                EditorGUI.indentLevel++;

                //   EditorGUILayout.Space();
                EditorGUILayout.BeginHorizontal();
                m_MaterialEditor.ShaderProperty(AddTexC, "UVClamp");
                m_MaterialEditor.ShaderProperty(AddTexCV, "");
                EditorGUILayout.EndHorizontal();

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                    EditorGUILayout.EndVertical();
                }


                m_MaterialEditor.ShaderProperty(AddTexAR, "使用R通道");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*不勾选附加图的A通道为它的透明通道，勾选附加图的R通道为它的透明通道", style);
                    EditorGUILayout.EndVertical();
                }



                m_MaterialEditor.ShaderProperty(IfAddTexColor, "参与颜色通道运算");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*附加图的颜色也会影响整体的颜色", style);
                    EditorGUILayout.EndVertical();
                }





                m_MaterialEditor.ShaderProperty(IfAddTexAlpha, "参与透明通道运算");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*附加图的透明通道也会影响整体的透明度", style);
                    EditorGUILayout.EndVertical();
                }




                m_MaterialEditor.ShaderProperty(AddTexRo, "贴图旋转");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.ShaderProperty(AddTexRefine, "Refine");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图校色，可以拉大贴图明暗对比，制作更富色彩变化性的纹理，原理就是给原图一个power值，使其边缘更加锐利，在和原图lerp方式叠加起来，四个选项分别对应原图强度，修改图强度，修改图power值，原图修改图lerp混合程度（0-1之间即可）", style);
                    EditorGUILayout.EndVertical();
                }

                GUILayout.Space(5);





                EditorGUI.indentLevel--;


            }

            EditorGUILayout.EndVertical();
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*展开后可以对贴图属性做一些设置，包含uvclamp，透明通道，旋转，校色", style);
                EditorGUILayout.EndVertical();
            }
            m_MaterialEditor.TextureScaleOffsetProperty(AddTex_Sampler);
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);

            m_MaterialEditor.ShaderProperty(AddTexBlendMode, "叠加模式");
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*附加图和主贴图的叠加方式，有lerp（即alpha）和add两种，根据效果需求选择叠加模式", style);
                EditorGUILayout.EndVertical();
            }

            GUILayout.Space(5);

            if (material.GetFloat("_AddTexBlendMode") == 0)
            {
                m_MaterialEditor.ShaderProperty(AddTexBlend, "融合系数");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*主贴图与附加图的融合比例，0为完全显示主贴图，1为完全显示附加图", style);
                    EditorGUILayout.EndVertical();
                }

                material.SetFloat("_AddTexAlpha", 0);

                GUILayout.Space(5);
            }






            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            m_MaterialEditor.ShaderProperty(AddTexUVS, "UV选择");

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("**包含normal默认UV，polar极坐标UV，cylinder圆筒UV,UV2四种模式，默认UV即模型自带UV，极坐标即中心向四周扩散UV，圆筒UV即世界坐标下一个圆筒包裹的UV，主帖图设置圆筒UV可以制作角色身上能量流动，或者渐变效果，UV2即使第二套UV。", style);
                EditorGUILayout.EndVertical();
            }







            if (material.GetFloat("_AddTexUVS") == 1)
            {
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(CenterU, "中心U");
                m_MaterialEditor.ShaderProperty(CenterV, "中心V");
                EditorGUILayout.EndVertical();

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*极坐标UV中心点位置", style);
                    EditorGUILayout.EndVertical();
                }

            }









            if (material.GetFloat("_AddTexUVS") == 2)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.ShaderProperty(Face, "圆柱朝向");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*世界坐标系下圆柱UV的朝向", style);
                    EditorGUILayout.EndVertical();
                }

                m_MaterialEditor.ShaderProperty(TexCenter, "圆柱中心");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*世界坐标系下圆柱UV的位置", style);
                    EditorGUILayout.EndVertical();
                }


                EditorGUILayout.EndVertical();



            }
            EditorGUILayout.EndVertical();

            GUILayout.Space(5);




            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(AddTexAC, "红蓝偏移");
            EditorGUILayout.EndVertical();

            GUILayout.Space(5);


            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(AddTexUspeed, "U流动");



            m_MaterialEditor.ShaderProperty(AddTexVspeed, "V流动");

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*附加图UV流动速度", style);
                EditorGUILayout.EndVertical();
            }
            EditorGUILayout.EndVertical();

            GUILayout.Space(5);




        }


        else 
        {

            material.SetFloat("_AddTexBlendMode", 0);

            material.SetFloat("_IfAddTexAlpha", 0);
        }

    }


    //Normal
    void GUI_CustomLight(Material material)
    {
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        m_MaterialEditor.ShaderProperty(LightScale, "光照强度");
        EditorGUILayout.EndVertical();
        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*接受的光照强度的整体衰减", style);
            EditorGUILayout.EndVertical();
        }
  

        m_MaterialEditor.TexturePropertySingleLine(new GUIContent("法线贴图"), NormalTex);

        if (_tips == true)
        {

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            style.fontSize = 10;
            style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
            GUILayout.Label("*法线图用来增加表面的光照细节，增强立体感", style);
            EditorGUILayout.EndVertical();
        }

        if (NormalTex.textureValue != null)

        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            _NormalTexxx = Foldouts(_NormalTexxx, "贴图设置(点击打开)");

            if (_NormalTexxx)
            {
                EditorGUI.indentLevel++;

                //   EditorGUILayout.Space();
                EditorGUILayout.BeginHorizontal();
                m_MaterialEditor.ShaderProperty(NormalTexC, "UVClamp");
                m_MaterialEditor.ShaderProperty(NormalTexCV, "");
                EditorGUILayout.EndHorizontal();

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*两个复选框分别表示贴图U方向Clamp和V方向Clamp，可以勾选其中一个，也可以两个方向都勾选", style);
                    EditorGUILayout.EndVertical();
                }






                m_MaterialEditor.ShaderProperty(NormalTex_Rotat, "贴图旋转");

                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*贴图旋转，处理贴图朝向，省去复制贴图改变朝向", style);
                    EditorGUILayout.EndVertical();
                }



                GUILayout.Space(5);





                EditorGUI.indentLevel--;


            }

            EditorGUILayout.EndVertical();
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*展开后可以对贴图属性做一些设置，包含uvclamp，旋转", style);
                EditorGUILayout.EndVertical();
            }
            m_MaterialEditor.TextureScaleOffsetProperty(NormalTex);
            EditorGUILayout.EndVertical();
            GUILayout.Space(5);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            GUILayout.Label("    UV与主帖图一致");
            EditorGUILayout.EndVertical();


            GUILayout.Space(5);


            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(NormalScale, "法线强度");
            EditorGUILayout.EndVertical();
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*法线强度值，负数时法线反转", style);
                EditorGUILayout.EndVertical();
            }

       

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            m_MaterialEditor.ShaderProperty(NormalTex_Uspeed, "U流动");



            m_MaterialEditor.ShaderProperty(NormalTex_Vspeed, "V流动");

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*法线图UV流动速度", style);
                EditorGUILayout.EndVertical();
            }
            EditorGUILayout.EndVertical();




            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginHorizontal();


            EditorGUILayout.PrefixLabel("开启动态法线");
            if (material.GetFloat("_IfStaticNormal") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_IfStaticNormal", 1);
                }
            }
            else

            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_IfStaticNormal", 0);

                }
            }

            EditorGUILayout.EndHorizontal();
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*动态法线是根据溶解图的黑白信息生成的动态法线，在溶解过程中，溶解边缘会产生厚度感，用来制作水，血液等液体材质的消散时的体积感", style);
                EditorGUILayout.EndVertical();
            }


            if (material.GetFloat("_IfStaticNormal") == 1)
            {
                GUILayout.Space(5);
                m_MaterialEditor.ShaderProperty(StaticNormalScale, "动态法线强度");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*动态法线的强度值，强度越强体积感越强", style);
                    EditorGUILayout.EndVertical();
                }
                GUILayout.Space(5);

                m_MaterialEditor.ShaderProperty(StaticNormalOffset, "动态法线偏移");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*动态法线的宽度，偏移越高，边缘法线的宽度也就越大", style);
                    EditorGUILayout.EndVertical();
                }
                GUILayout.Space(5);
            }
            EditorGUILayout.EndVertical();







        }
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginHorizontal();

        
            EditorGUILayout.PrefixLabel("开启环境图反射");
            if (material.GetFloat("_IfCubemap") == 0)
            {
                if (GUILayout.Button("已关闭", shortButtonStyle))
                {
                    material.SetFloat("_IfCubemap", 1);
                }
            }
            else

            {
                if (GUILayout.Button("已开启", shortButtonStyle))
                {
                    material.SetFloat("_IfCubemap", 0);

                }
            }

            EditorGUILayout.EndHorizontal();


            if (material.GetFloat("_IfCubemap") == 1)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                m_MaterialEditor.TexturePropertySingleLine(new GUIContent("CubeMap贴图"), CubeMap);
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*CubeMap可以用来模拟环境反射，增加材质的质感，使材质更加具光滑感", style);
                    EditorGUILayout.EndVertical();
                }
                m_MaterialEditor.TextureScaleOffsetProperty(CubeMap);
                EditorGUILayout.EndVertical();

                m_MaterialEditor.ShaderProperty(CubemapScale, "Cubemap图强度");
                if (_tips == true)
                {

                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    style.fontSize = 10;
                    style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                    GUILayout.Label("*CubeMap的整体强度值", style);
                    EditorGUILayout.EndVertical();
                }
            }
            else {
                material.SetFloat("_CubemapScale", 0);
            }






            EditorGUILayout.EndVertical();




           



            GUILayout.Space(5);















    }

   // 
        
    void GUI_para(Material material)

    {


     //   

         
            m_MaterialEditor.TexturePropertySingleLine(new GUIContent("深度贴图"), ParaTex);
  
            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*灰度图即可，黑色部分会下凹，白色部分不变", style);
                EditorGUILayout.EndVertical();
            }



            GUILayout.Space(5);

            m_MaterialEditor.ShaderProperty(Parallax, "深度值");

            if (_tips == true)
            {

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                style.fontSize = 10;
                style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
                GUILayout.Label("*下凹的强度值", style);
                EditorGUILayout.EndVertical();
            }



            GUILayout.Space(5);

        if (ParaTex.textureValue == null) {

            material.SetFloat("_Parallax",0);
        }




    }




    void GUI_mengban(Material material)

    {

        EditorGUILayout.BeginHorizontal();


        EditorGUILayout.PrefixLabel("模板测试方案");
        if (material.GetFloat("_StencilStyle") == 0)
        {
            if (GUILayout.Button("已关闭", shortButtonStyle))
            {
                material.SetFloat("_StencilStyle", 1);
                material.SetFloat("_Reference", 0);
                material.SetFloat("_Comparison", 8);
                material.SetFloat("_Pass", 0);
                material.SetFloat("_Fail", 0);
            }
        }
       
        else {
            if (GUILayout.Button("自由模式", shortButtonStyle))
            {
                material.SetFloat("_StencilStyle", 0);
                material.SetFloat("_Reference", 0);
                material.SetFloat("_Comparison", 8);
                material.SetFloat("_Pass", 0);
                material.SetFloat("_Fail", 0);
            }
        }



        EditorGUILayout.EndHorizontal();


        GUILayout.Space(5);

        if (material.GetFloat("_StencilStyle") == 1) { 
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        m_MaterialEditor.ShaderProperty(Reference, "模板参考值");

        m_MaterialEditor.ShaderProperty(Comparison, "比较方式");

        m_MaterialEditor.ShaderProperty(Pass, "通过运算");

        m_MaterialEditor.ShaderProperty(Fail, "失败运算");
        EditorGUILayout.EndVertical();
        }
    }

    void GUI_Tip(Material material)

    {


        style.fontSize = 12;
        style.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
        style.wordWrap = true;


        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        GUILayout.Label(" 1.开启自定义数据时请先添加custom1.xyzw,再添加custom2.xyzw", style);
       
        GUILayout.Space(5); GUILayout.Label(" 2.开启溶解拖尾模式后，透明度改为溶解参数", style);

        GUILayout.Space(5);
        EditorGUILayout.EndVertical();



        EditorGUILayout.BeginVertical(EditorStyles.helpBox);


        GUILayout.Label("本shader由油腻联盟坏熊猫制作，特别感谢闻亚洲，Nor_Zed，sion，123木头人，lolming，Allen，苏坤，AmantJy，仲冬，馒头,自赎,Cokey,J迷,AimerLily,救救孩子,XRX的帮助与支持", style);
        EditorGUILayout.EndVertical();

    }







  

}