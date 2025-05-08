namespace Northwind.Demo.Common
{
    public enum MessageCode
    {
        ICS0000EEF_Timeout,
        ICS0000EWB_RequiredField,
        ICS0000AEB_InvalidValue,
        ICS0000EEB_NotFound,
        ICS0000EEB_Duplicate,
        ICS0000EEB_UserNotFound,
        ICS0000BIF_Registered,
        ICS0000BIF_PageTitle,
        ICS0000BWF_FieldRequired,
        ICS0000BWF_SelectionRequired,
        ICS0000BIF_ConfirmExport,
        ICS0000BIF_Imported,
        ICS0000BWF_InvalidFile,
        ICS0000BIF_ConfirmDelete,
        ICS0000AEB_BeforeOther
    }
    public enum MessageType
    {
        ERROR,
        WARNING,
        INFO,
    }
    public record ErrorMessage(string Code, string level, string Message);
    public record ErrorMessageHelper(string Code, MessageType Level, string Message);

    public static class TestTransient
    {

        private readonly static Dictionary<MessageCode, ErrorMessageHelper> _definitions = new()
            {
              { MessageCode.ICS0000EEF_Timeout, new ("ICS0000EEF",  MessageType.ERROR,  "タイムアウトしました。" )},
              { MessageCode.ICS0000EWB_RequiredField, new("ICS0000EWB", MessageType.WARNING, "{0}は必須入力です。")},
              { MessageCode.ICS0000AEB_InvalidValue, new ("ICS0000AEB", MessageType.ERROR, "{0}が正しくありません。")},
              { MessageCode.ICS0000EEB_NotFound, new("ICS0000EEB", MessageType.ERROR, "{0}が見つかりません。")},
              { MessageCode.ICS0000EEB_Duplicate, new("ICS0000EEB", MessageType.ERROR, "同じ値のデータを登録できません。")},
              { MessageCode.ICS0000EEB_UserNotFound, new("ICS0000EEB", MessageType.ERROR, "IDに存在しないユーザIDです。")},
              { MessageCode.ICS0000BIF_Registered, new("ICS0000BIF", MessageType.INFO, "登録しました。")},
              { MessageCode.ICS0000BIF_PageTitle, new("ICS0000BIF", MessageType.INFO, "メッセージです。")},
              { MessageCode.ICS0000BWF_FieldRequired, new("ICS0000BWF", MessageType.WARNING, "{0}は入力必須です。")},
              { MessageCode.ICS0000BWF_SelectionRequired, new ("ICS0000BWF", MessageType.WARNING, "{0}は選択必須です。")},
              { MessageCode.ICS0000BIF_ConfirmExport, new("ICS0000BIF", MessageType.INFO, "{0}を出力しますか？")},
              { MessageCode.ICS0000BIF_Imported, new("ICS0000BIF", MessageType.INFO, "インポートしました。")},
              { MessageCode.ICS0000BWF_InvalidFile, new("ICS0000BWF", MessageType.WARNING, "ファイル形式が正しくありません。")},
              { MessageCode.ICS0000BIF_ConfirmDelete, new("ICS0000BIF", MessageType.INFO, "削除しますか？")},
              { MessageCode.ICS0000AEB_BeforeOther, new("ICS0000AEB", MessageType.ERROR, "{1}が{0}より前です。")},
            };

        private static string ErrorLevelFactory(MessageType messageType)
        {
            return messageType switch
            {
                MessageType.ERROR => "エラー",
                MessageType.WARNING => "ワーニング",
                MessageType.INFO => "インフォメーション",
                _ => "エラー",
            };
        }

        public static ErrorMessage ErrorMessageFactory(MessageCode errorKind, params object[] args)
        {
            if (_definitions.TryGetValue(errorKind, out ErrorMessageHelper? def) && def != null)
            {
                return new(def.Code,
                     ErrorLevelFactory(def.Level),
                    string.Format(def.Message, args));

            }
            return new("ICS0000EEF", ErrorLevelFactory(MessageType.ERROR), "不明なエラーが発生しました。");
        }
    }
}
