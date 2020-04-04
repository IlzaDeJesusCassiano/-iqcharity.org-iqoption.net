using System.Runtime.Serialization;

namespace iqoptionapi.ws.@base {

    public struct MessageType {

        public const string Front = "front";
        public const string Profile = "profile";
        public const string Heartbeat = "heartbeat";

        public const string SendMessage = "sendMessage";
        public const string TimeSync = "timeSync";
        public const string OptionOpened = "option-opened";
        public const string OptionClosed = "option-closed";
        public const string OptionArchived = "option-archived";

        public const string SocketOptionOpened = "socket-option-opened";
        public const string SubscribeMessage = "subscribemessage";
        public const string UnsubscribeMessage = "unsubscribemessage";

        public const string UserTournamentPositionChanged = "user-tournament-position-changed";


        public const string Getinstruments = "get-instruments";
        public const string Ssid = "ssid";

        public const string BalanceChanged = "balance-changed";
        public const string Candles = "candles";

    }

}