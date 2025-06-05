namespace AssetTool
{
    [JsonAsset("GizmoAxisTranslationParameterSource")]
    public class UGizmoAxisTranslationParameterSource : UGizmoBaseFloatParameterSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoPlaneTranslationParameterSource")]
    public class UGizmoPlaneTranslationParameterSource : UGizmoBaseVec2ParameterSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoAxisRotationParameterSource")]
    public class UGizmoAxisRotationParameterSource : UGizmoBaseFloatParameterSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoUniformScaleParameterSource")]
    public class UGizmoUniformScaleParameterSource : UGizmoBaseVec2ParameterSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoAxisScaleParameterSource")]
    public class UGizmoAxisScaleParameterSource : UGizmoBaseFloatParameterSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoPlaneScaleParameterSource")]
    public class UGizmoPlaneScaleParameterSource : UGizmoBaseVec2ParameterSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}