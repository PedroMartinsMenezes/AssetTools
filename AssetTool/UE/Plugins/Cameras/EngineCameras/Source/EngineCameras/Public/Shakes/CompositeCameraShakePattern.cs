namespace AssetTool
{
    [JsonAsset("CompositeCameraShakePattern")]
    public class UCompositeCameraShakePattern : UCameraShakePattern
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}