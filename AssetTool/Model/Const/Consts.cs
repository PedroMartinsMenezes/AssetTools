namespace AssetTool
{
    public static class Consts
    {
        public const string None = "None";

        #region UObjects
        public const string ArrayProperty = "ArrayProperty";
        #endregion

        #region Property Types
        public const string CurveFloat = "CurveFloat";
        public const string CurveLinearColor = "CurveLinearColor";
        public const string MapProperty = "MapProperty";
        public const string OptionalProperty = "OptionalProperty";
        public const string SetProperty = "SetProperty";
        public const string SoftObjectProperty = "SoftObjectProperty";
        #endregion

        #region Property Names
        public const string Guid = "Guid";
        public const string VarGuid = "VarGuid";
        public const string PinValueType = "PinValueType";
        #endregion

        #region TextureStreamingTypes
        public const int TEXSTREAM_MAX_NUM_UVCHANNELS = 4;
        #endregion

        #region MeshUVChannelInfo
        public const int MAX_TEXCOORDS = 4;
        #endregion

        #region GPUSkinPublicDefs
        public const int MAX_TOTAL_INFLUENCES = 12;
        public const int EXTRA_BONE_INFLUENCES = 8;
        public const int MAX_INFLUENCES_PER_STREAM = 4;
        public const int MAX_APEXCLOTH_VERTICES_FOR_UB = 2048;
        public const int MAX_APEXCLOTH_VERTICES_FOR_VB = 65536;
        public const int GPUSKINCACHE_FRAMES = 3;
        #endregion
    }
}
