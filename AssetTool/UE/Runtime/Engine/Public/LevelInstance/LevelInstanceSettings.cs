namespace AssetTool
{
    [JsonAsset("LevelInstanceSettings")]
    public class ULevelInstanceSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}