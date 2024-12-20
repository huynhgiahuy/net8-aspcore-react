export const saveToLocalStorage = (name: string, values: unknown): void => {
    if (typeof window === "undefined" || !window.localStorage) {
        return;
    }

    window.localStorage.setItem(`${name}`, JSON.stringify(values));
};

export const loadFromLocalStorage = (name: string): string | null => {
    if (typeof window === "undefined" || !window.localStorage) {
        return null;
    }

    const serialized = window.localStorage.getItem(`${name}`);
    return serialized !== null ? JSON.parse(serialized) : null;
};

export const removeFromLocalStorage = (name: string) => {
    if (typeof window === "undefined" || !window.localStorage) {
        return;
    }

    window.localStorage.removeItem(`${name}`);
};

export const saveToSessionStorage = (name: string, values: unknown): void => {
    if (typeof window === "undefined" || !window.sessionStorage) {
        return;
    }

    window.sessionStorage.setItem(`${name}`, JSON.stringify(values));
};

export const loadFromSessionStorage = (name: string): string | null => {
    if (typeof window === "undefined" || !window.sessionStorage) {
        return null;
    }

    const serialized = window.sessionStorage.getItem(`${name}`);
    return serialized !== null ? JSON.parse(serialized) : null;
};

export const removeFromSessionStorage = (name: string) => {
    if (typeof window === "undefined" || !window.sessionStorage) {
        return;
    }

    window.sessionStorage.removeItem(`${name}`);
};