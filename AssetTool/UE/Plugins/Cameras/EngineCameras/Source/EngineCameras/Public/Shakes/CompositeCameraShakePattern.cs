namespace AssetTool
{
    [JsonAsset("CompositeCameraShakePattern")]
    public class UCompositeCameraShakePattern : UCameraShakePattern
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}