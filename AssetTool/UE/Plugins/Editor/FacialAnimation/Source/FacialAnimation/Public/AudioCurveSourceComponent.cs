namespace AssetTool
{
    [JsonAsset("AudioCurveSourceComponent")]
    public class UAudioCurveSourceComponent : UAudioComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}