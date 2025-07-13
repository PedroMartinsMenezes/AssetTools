namespace AssetTool
{
    [JsonAsset("AnimNotifyEventNodeSpawner")]
    public class UAnimNotifyEventNodeSpawner : UBlueprintEventNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}