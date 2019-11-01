package vdro.tau.fish.service;

import java.util.List;

public interface AccessManager extends RecordAccessManager {
    List<EntryRecord> ReadAll();
}
