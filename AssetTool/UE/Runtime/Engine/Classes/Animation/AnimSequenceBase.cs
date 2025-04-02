namespace AssetTool
{
    [JsonAsset("AnimSequenceBase")]
    public class UAnimSequenceBase : UAnimationAsset
    {
        public List<FFloatCurve> FloatCurves;
        public List<FTransformCurve> TransformCurves;

        public UAnimSequenceBase()
        {
            ArrayNotifiers.Add("FloatCurves", (transfer) =>
            {
                if (transfer.IsReading)
                {
                    FloatCurves ??= new();
                    FloatCurves.Add(new());
                }
            });
            ArrayNotifiers.Add("TransformCurves", (transfer) =>
            {
                if (transfer.IsReading)
                {
                    TransformCurves ??= new();
                    TransformCurves.Add(new());
                }
            });
        }

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            PostSerializeFixup(transfer);
            return this;
        }

        [Location("void FRawCurveTracks::PostSerializeFixup(FArchive& Ar)")]
        private void PostSerializeFixup(Transfer transfer)
        {
            foreach (FFloatCurve Curve in FloatCurves ?? [])
            {
                Curve.PostSerializeFixup(transfer);
            }
            if (transfer.Supports.VER_UE4_ANIMATION_ADD_TRACKCURVES)
            {
                foreach (FTransformCurve Curve in TransformCurves ?? [])
                {
                    Curve.PostSerializeFixup(transfer);
                }
            }
        }
    }
}