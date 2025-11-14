namespace AssetTool
{
    [JsonAsset("LyraSettingValueScalarDynamic_SafeZoneValue")]
    public class ULyraSettingValueScalarDynamic_SafeZoneValue : UGameSettingValueScalarDynamic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraSettingAction_SafeZoneEditor")]
    public class ULyraSettingAction_SafeZoneEditor : UGameSettingAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}