namespace AssetTool
{
    public static class Supports
    {
        #region EUnrealEngineObjectUE4Version
        public static bool VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT);
        public static bool VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG);
        public static bool VAR_UE4_ARRAY_PROPERTY_INNER_TAGS => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VAR_UE4_ARRAY_PROPERTY_INNER_TAGS);
        public static bool VER_UE4_TemplateIndex_IN_COOKED_EXPORTS => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS);
        public static bool VER_UE4_64BIT_EXPORTMAP_SERIALSIZES => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES);
        public static bool VER_UE4_LOAD_FOR_EDITOR_GAME => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_LOAD_FOR_EDITOR_GAME);
        public static bool VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT);
        public static bool VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS);
        public static bool VER_UE4_NON_OUTER_PACKAGE_IMPORT => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT);
        public static bool VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS);
        #endregion

        #region EUnrealEngineObjectUE5Version
        public static bool OPTIONAL_RESOURCES => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.OPTIONAL_RESOURCES);
        public static bool TRACK_OBJECT_EXPORT_IS_INHERITED => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.TRACK_OBJECT_EXPORT_IS_INHERITED);
        public static bool REMOVE_OBJECT_EXPORT_PACKAGE_GUID => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.REMOVE_OBJECT_EXPORT_PACKAGE_GUID);
        #endregion

        public static int UEVer4() => GlobalObjects.PackageFileSummary.FileVersionUE.FileVersionUE4;
        public static int UEVer5() => GlobalObjects.PackageFileSummary.FileVersionUE.FileVersionUE5;
        public static bool UEVer(EUnrealEngineObjectUE4Version value) => GlobalObjects.UESupport(value);
        public static bool UEVer(EUnrealEngineObjectUE5Version value) => GlobalObjects.UESupport(value);

        public static bool CustomVer(FCoreObjectVersion.Enums value) => GlobalObjects.CustomVer(FCoreObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FFrameworkObjectVersion.Enums value) => GlobalObjects.CustomVer(FFrameworkObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FReleaseObjectVersion.Enums value) => GlobalObjects.CustomVer(FReleaseObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FFortniteReleaseBranchCustomObjectVersion.Enums value) => GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FUE5MainStreamObjectVersion.Enums value) => GlobalObjects.CustomVer(FUE5MainStreamObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FBlueprintsObjectVersion.Enums value) => GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FEditorObjectVersion.Enums value) => GlobalObjects.CustomVer(FEditorObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FUE5ReleaseStreamObjectVersion.Enums value) => GlobalObjects.CustomVer(FUE5ReleaseStreamObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FRenderingObjectVersion.Enums value) => GlobalObjects.CustomVer(FRenderingObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FFortniteMainBranchObjectVersion.Enums value) => GlobalObjects.CustomVer(FFortniteMainBranchObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FSkeletalMeshCustomVersion.Enums value) => GlobalObjects.CustomVer(FSkeletalMeshCustomVersion.Guid) >= (int)value;
        public static bool CustomVer(FRecomputeTangentCustomVersion.Enums value) => GlobalObjects.CustomVer(FRecomputeTangentCustomVersion.Guid) >= (int)value;

        public static bool IsCompatible() => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_OLDEST_LOADABLE_PACKAGE);
    }
}
