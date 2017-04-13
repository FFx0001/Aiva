﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Aiva.Core.Database {
    public class UserSettingsHandler {
        public static List<Storage.UserSettings> GetConfig() {
            using (var context = new Storage.StorageEntities()) {
                return context.UserSettings.ToList();
            }
        }

        public static void WriteConfig(List<Storage.UserSettings> settings) {
            using (var context = new Storage.StorageEntities()) {

                foreach (var setting in settings) {
                    var entry = context.UserSettings.SingleOrDefault(x => String.Compare(setting.Name, x.Name, true) == 0);

                    if (entry != null)
                        entry.Value = setting.Value;
                }
                context.SaveChanges();
            }
        }

        public static bool GetBoolean(string name) {
            using (var context = new Storage.StorageEntities()) {
                return Convert.ToBoolean(context.UserSettings.SingleOrDefault(x => x.Name == name).Value);
            }
        }

        public static List<string> GetBlacklistedWords() {
            using (var context = new Storage.StorageEntities()) {
                return context.UserSettings.SingleOrDefault(x => x.Name == "BlacklistedWords").Value.Split(',').ToList();
            }
        }
    }
}