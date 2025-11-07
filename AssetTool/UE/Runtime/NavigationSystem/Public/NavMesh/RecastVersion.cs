namespace AssetTool
{
    public static partial class Consts
    {
        public const int NAVMESHVER_INITIAL = 1;
        public const int NAVMESHVER_TILED_GENERATION = 2;
        public const int NAVMESHVER_SEAMLESS_REBUILDING_1 = 3;
        public const int NAVMESHVER_AREA_CLASSES = 4;
        public const int NAVMESHVER_CLUSTER_PATH = 5;
        public const int NAVMESHVER_SEGMENT_LINKS = 6;
        public const int NAVMESHVER_DYNAMIC_LINKS = 7;
        public const int NAVMESHVER_64BIT = 9;
        public const int NAVMESHVER_CLUSTER_SIMPLIFIED = 10;
        public const int NAVMESHVER_OFFMESH_HEIGHT_BUG = 11;
        public const int NAVMESHVER_LANDSCAPE_HEIGHT = 13;
        public const int NAVMESHVER_LWCOORDS = 14;
        public const int NAVMESHVER_OODLE_COMPRESSION = 15;
        public const int NAVMESHVER_LWCOORDS_SEREALIZATION = 17;
        public const int NAVMESHVER_MAXTILES_COUNT_CHANGE = 19;
        public const int NAVMESHVER_LWCOORDS_OPTIMIZATION = 20;
        public const int NAVMESHVER_OPTIM_FIX_SERIALIZE_PARAMS = 21;
        public const int NAVMESHVER_MAXTILES_COUNT_SKIP_INCLUSION = 22;
        public const int NAVMESHVER_TILE_RESOLUTIONS = 23;
        public const int NAVMESHVER_TILE_RESOLUTIONS_CELLHEIGHT = 24;
        public const int NAVMESHVER_1_VOXEL_AGENT_STEEP_SLOPE_FILTER_FIX = 25;
        public const int NAVMESHVER_TILE_RESOLUTIONS_AGENTMAXSTEPHEIGHT = 26;

        public const int NAVMESHVER_LATEST = NAVMESHVER_TILE_RESOLUTIONS_AGENTMAXSTEPHEIGHT;
        public const int NAVMESHVER_MIN_COMPATIBLE = NAVMESHVER_LWCOORDS_OPTIMIZATION;
    }
}