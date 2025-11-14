namespace AssetTool
{
    [JsonAsset("GameplayTasksComponent")]
    public class UGameplayTasksComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}