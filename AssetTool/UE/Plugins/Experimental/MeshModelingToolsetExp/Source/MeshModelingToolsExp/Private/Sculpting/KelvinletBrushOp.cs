namespace AssetTool
{
    [JsonAsset("BaseKelvinletBrushOpProps")]
    public class UBaseKelvinletBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScaleKelvinletBrushOpProps")]
    public class UScaleKelvinletBrushOpProps : UBaseKelvinletBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PullKelvinletBrushOpProps")]
    public class UPullKelvinletBrushOpProps : UBaseKelvinletBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SharpPullKelvinletBrushOpProps")]
    public class USharpPullKelvinletBrushOpProps : UBaseKelvinletBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TwistKelvinletBrushOpProps")]
    public class UTwistKelvinletBrushOpProps : UBaseKelvinletBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}