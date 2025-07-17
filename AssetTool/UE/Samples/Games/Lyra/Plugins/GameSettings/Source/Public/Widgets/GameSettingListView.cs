namespace AssetTool
{
    [JsonAsset("GameSettingListView")]
    public class UGameSettingListView : UListView
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}