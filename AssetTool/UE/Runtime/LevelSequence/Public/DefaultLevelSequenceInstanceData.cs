namespace AssetTool
{
    [JsonAsset("DefaultLevelSequenceInstanceData")]
    public class UDefaultLevelSequenceInstanceData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}