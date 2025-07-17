namespace AssetTool
{
    [JsonAsset("LyraBotCreationComponent")]
    public class ULyraBotCreationComponent : UGameStateComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}