namespace AssetTool
{
    [JsonAsset("LevelInstanceSettings")]
    public class ULevelInstanceSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}