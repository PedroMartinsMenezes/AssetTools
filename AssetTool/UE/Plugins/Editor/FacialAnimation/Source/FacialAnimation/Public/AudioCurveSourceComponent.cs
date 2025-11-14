namespace AssetTool
{
    [JsonAsset("AudioCurveSourceComponent")]
    public class UAudioCurveSourceComponent : UAudioComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}