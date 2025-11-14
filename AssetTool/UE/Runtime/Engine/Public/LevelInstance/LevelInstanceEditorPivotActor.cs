namespace AssetTool
{
    [JsonAsset("LevelInstancePivot")]
    public class ALevelInstancePivot : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}