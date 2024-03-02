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
        #endregion

        #region EUnrealEngineObjectUE5Version
        public static bool OPTIONAL_RESOURCES => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.OPTIONAL_RESOURCES);
        public static bool TRACK_OBJECT_EXPORT_IS_INHERITED => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.TRACK_OBJECT_EXPORT_IS_INHERITED);
        #endregion

        #region FUE5ReleaseStreamObjectVersion
        public static bool MaterialInterfaceSavedCachedData => true;
        #endregion

        #region FUE5MainStreamObjectVersion
        public static bool MaterialSavedCachedData => true;
        #endregion
    }
}
