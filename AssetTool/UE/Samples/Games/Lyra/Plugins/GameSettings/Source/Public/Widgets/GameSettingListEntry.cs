namespace AssetTool
{
    [JsonAsset("GameSettingListEntryBase")]
    public class UGameSettingListEntryBase : UCommonUserWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameSettingListEntry_Setting")]
    public class UGameSettingListEntry_Setting : UGameSettingListEntryBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameSettingListEntrySetting_Discrete")]
    public class UGameSettingListEntrySetting_Discrete : UGameSettingListEntry_Setting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameSettingListEntrySetting_Scalar")]
    public class UGameSettingListEntrySetting_Scalar : UGameSettingListEntry_Setting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameSettingListEntrySetting_Action")]
    public class UGameSettingListEntrySetting_Action : UGameSettingListEntry_Setting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameSettingListEntrySetting_Navigation")]
    public class UGameSettingListEntrySetting_Navigation : UGameSettingListEntry_Setting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}