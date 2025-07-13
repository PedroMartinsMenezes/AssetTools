namespace AssetTool
{
    [JsonAsset("SequenceCameraShakePattern")]
    public class USequenceCameraShakePattern : UCameraShakePattern
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}