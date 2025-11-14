namespace AssetTool
{
    [JsonAsset("SequenceCameraShakePattern")]
    public class USequenceCameraShakePattern : UCameraShakePattern
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}