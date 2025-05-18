namespace AssetTool
{
    [JsonAsset("MoviePipelineDeferredPassBase")]
    public class UMoviePipelineDeferredPassBase : UMoviePipelineImagePassBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineDeferredPass_Unlit")]
    public class UMoviePipelineDeferredPass_Unlit : UMoviePipelineDeferredPassBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineDeferredPass_DetailLighting")]
    public class UMoviePipelineDeferredPass_DetailLighting : UMoviePipelineDeferredPassBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineDeferredPass_LightingOnly")]
    public class UMoviePipelineDeferredPass_LightingOnly : UMoviePipelineDeferredPassBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineDeferredPass_ReflectionsOnly")]
    public class UMoviePipelineDeferredPass_ReflectionsOnly : UMoviePipelineDeferredPassBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineDeferredPass_PathTracer")]
    public class UMoviePipelineDeferredPass_PathTracer : UMoviePipelineDeferredPassBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}