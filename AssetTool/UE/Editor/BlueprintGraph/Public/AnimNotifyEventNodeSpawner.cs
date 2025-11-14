namespace AssetTool
{
    [JsonAsset("AnimNotifyEventNodeSpawner")]
    public class UAnimNotifyEventNodeSpawner : UBlueprintEventNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}