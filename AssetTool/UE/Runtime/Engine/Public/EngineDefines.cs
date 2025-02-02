namespace AssetTool
{
    public static partial class Consts
    {
        public const int NUM_INDIRECT_LIGHTING_SH_COEFFICIENTS = 9;

        public const int NUM_ATMOSPHERE_LIGHTS = 2;

        #region Size of the world.

        public const double UE_OLD_WORLD_MAX = 2097152.0;
        public const double UE_OLD_HALF_WORLD_MAX = UE_OLD_WORLD_MAX * 0.5;
        public const double UE_OLD_HALF_WORLD_MAX1 = UE_OLD_HALF_WORLD_MAX - 1;

        public const double UE_LARGE_WORLD_MAX = 8796093022208.0;
        public const double UE_LARGE_HALF_WORLD_MAX = UE_LARGE_WORLD_MAX * 0.5;
        public const double UE_LARGE_HALF_WORLD_MAX1 = UE_LARGE_HALF_WORLD_MAX - 1;

        public const double UE_FLOAT_HUGE_DISTANCE = 1048576.0;
        public const double UE_DOUBLE_HUGE_DISTANCE = 562949953421312.0;

        public const double DEFAULT_ORTHOZOOM = 10000.0;

        public const int SDPG_NumBits = 3;

        #endregion
    }
}
